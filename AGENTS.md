# Virtual Love (三点だいしゅきツール) development

The multilingual release uses `codex/v3.2.0-localization` in this primary checkout.
Merge released `main` fixes into it. Before any commit verify both author and
committer are `UnisakiStudio <unisaki.studio@gmail.com>` and retain Git guards.

Every feature/fix must include its display translations and terminology check, not
just Japanese and English. Read `../PosingSystem/Tools/Localization/README.md` first.
Include Inspector titles, license notices, native menus, pose names, generated menus
and the README/changelog. Preserve IDs, paths, parameters, asset references, saved
object names (`三点だいしゅき(男)` / `三点だいしゅき(女)`) and custom names. Pose names
are translated as a complete set per language and keep their `A1-` … `Ex-` prefixes;
category menus keep `[A]` … `[Ex]`. Never count fallback as translation or silently
send text to external translation services. Public publication needs new approval.

## Product-owned translations

This product's display text lives here, not in PosingSystem:

- Reviewed tables: `Tools/Localization/product.translations.json` (29 target languages,
  Japanese source text as key) and `Tools/Localization/display-names.json`.
- Generated, do not edit: `Packages/jp.unisakistudio.virtuallove/Editor/Localization/translations.json`.
  Regenerate from the PosingSystem checkout with `python Tools/Localization/build_catalogs.py`,
  then run its `validate_catalogs.py` and `audit_coverage.py` (they include this repository).
- License dialogs are composed of this product's sentences plus shared sentences owned by
  PosingSystem (`Tools/InstallerLocalization`). The shared lookup translates each line, so
  every complete line must be an exact key either here or there. A key has one owner.
- English and other languages call the product "Virtual Love"; 男/女 are rendered with the
  ordinary adult words for male/female.

## Product-owned documentation

Unlike the three main products, this product keeps its documentation data in this
repository, so changing it never alters the shared digests:

- Frozen sources: `Tools/Documentation/sources.json`
  (`python ../PosingSystem/Tools/Documentation/freeze_sources.py --product VirtualLove`).
- Translations: `Tools/Documentation/translations/<locale>.json`; reviewed inflections for the
  terminology gate, if any, in `Tools/Documentation/Reviews/<locale>.json`.
- Build and check from the PosingSystem checkout:
  `python Tools/Documentation/build_documents.py --data ../VirtualLove/Tools/Documentation --report <file>`
  (add `--check` for the read-only gate) and
  `python Tools/Documentation/audit_terminology.py --data ../VirtualLove/Tools/Documentation --strict --report <file>`.
- The package README doubles as the offline guide (`UserGuide` pages are generated from it),
  so the Inspector's guide link follows the selected language.
- `python Tools/Documentation/check_documents.py` is the self-contained gate of this repository.

All 30 languages need the full README and the complete historical CHANGELOG. Paragraphs that
are identical to the main products' documents should stay identical so their reviewed
translations can be reused. Upcoming versions stay unreleased until actual publication.
