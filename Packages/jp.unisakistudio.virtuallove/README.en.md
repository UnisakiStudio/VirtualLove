# Virtual Love

A VRChat avatar tool for enjoying paired poses with a partner in 3-point tracking or desktop mode. It includes 22 poses for each of the male and female sides, 44 in total. A standing split and the Jack-O challenge are also included.

This README covers v3.2.0, currently in development. A release date has not been set. Check the installed version at the top of the Inspector.

- [BOOTH product page](https://yunisaki.booth.pm/items/3641334)
- [Changelog](Documentation~/Localization/en/CHANGELOG.md)

## Display language and offline documentation

Choose a display language with Language / 言語 at the top of the Inspector. One selection controls both the Inspector and generated VRChat menu. Re-upload the avatar to change its in-game language.

Without a saved choice, the tool follows the computer's language and uses English for unsupported languages. This works on Windows, macOS and Linux. The last selection is saved in EditorPrefs and reused in other projects belonging to the same OS user on this computer. All posing tools and avatars use the same language. Changing it in any tool's Inspector updates the shared preference; per-avatar language choices are ignored. Preferences do not sync to other computers. License storage is unchanged. The language button appears only on the initial setup confirmation when no language is saved. Later language changes are made in the Inspector.

Choose a README or changelog from the bundled [language index](Documentation~/Localization/index.html). The Inspector's Manual and View changelog also follow the selected language. The names of the included poses and of the in-game menu categories are shown in the selected language too. The terms of use remain bundled in Japanese, as before.

## Installation

1. Import VirtualLove_Boy.unitypackage or VirtualLove_Girl.unitypackage from your purchased files into Unity. In the English edition, the files are named VirtualLove_Male_Installer.unitypackage and VirtualLove_Female_Installer.unitypackage.
2. Once the package source is registered, you can add Virtual Love to your project from VCC or ALCOM. Unisaki Posing System 3.2.0 is required.
3. In the Hierarchy, right-click the avatar and choose Unisaki Studio > Add Virtual Love (Male) or Unisaki Studio > Add Virtual Love (Female).
4. Select 三点だいしゅき(男) or 三点だいしゅき(女), which was added inside the avatar, and set the features and poses in the Inspector.
5. Check the poses with Preview, then upload the avatar as usual.

Requires Unity 2022.3, VRChat Avatars SDK 3.10.4 or later, Modular Avatar 1.x version 1.15.1 or later, and NDMF 1.x version 1.14.0 or later. Update the required packages together in VCC or ALCOM.

## Updating from an earlier version

Update this product and Unisaki Posing System together. Existing tool settings are carried over. Check enabled features and ExpressionParameters usage in the Inspector. If you use prebuilds, click Update prebuild before re-uploading.

## Where to configure settings

| Tab | Main settings |
| --- | --- |
| Features | In-game menu features, Photo Mode, breathing, icon images and the parameter usage check |
| Poses | Poses to use, search, adding, reordering, Preview and Animation Adjustment |
| Avatar Setup | Body correction, importing the original posture and your own motions, and presets |

Turn on the features you need before uploading. Items with Open settings can show detailed settings below them.

## Basic in-game controls

Open the Expressions menu and choose a Virtual Love pose. Choose the poses that pair up between the male and female sides, then match your position and direction with your partner.

Switch the head, arm and feet locks to choose which parts follow your tracking. With Lock Feet, you can move your head while the lower body keeps its pose. To mirror a pose or adjust its height, enable the matching features in Unity beforehand.

### Photo Mode

Move your avatar to where you can see it, adjust its direction and take photos.

1. In Unity, turn on Features > Menu features > Photo Mode.
2. In VRChat, open Photo Mode and choose a pose under Select Pose.
3. Use Distance to move the avatar up to 3m forward. When the distance is above 0, the avatar faces you.
4. Rotate it with Direction and, once it is in place, turn on Lock Feet if needed. The feet are not locked automatically at the start, so you can adjust the position first.
5. When you are done, press Exit Photo Mode. The distance and direction are reset and Lock Feet is released.

If you added Disable Gestures to the menu, you can switch hand shapes inside Photo Mode as well.

Changing the position and direction only on your own screen uses no synced Photo Mode parameters. To show the same position and direction to other people, turn on Features > Convenience > Sync Photo Mode in Unity.

If your own head disappears when it gets close and makes photos difficult, turn on Keep your head visible in Photo Mode. It applies to your own view while photographing and returns to normal afterward.

### Foot Height and Floor Height

Turn on the items you want under Features > Menu features in Unity to add them to the Settings menu in VRChat.

- **Foot Height**: adjusts the height of the feet side while keeping the head position. Use it when the feet sink into or float above the floor, or to match your partner's height.
- **Floor Height**: moves the whole body, including the head, up and down. 50% is the original height, 0% is 3m below and 100% is 3m above. Return it to around 50% to go back.

Combine these with Photo Mode to adjust the avatar's height, distance and direction. Photo Mode movement and rotation and Floor Height also correct the default and custom motions used while no pose is selected. Check the final viewpoint and the behavior after motion replacement in VRChat itself.

### Mirror and Disable Gestures

- **Mirror**: turn on Features > Menu features > Mirror, then flip a pose left and right from the VRChat menu.
- **Disable Gestures**: turn on Features > Menu features > Disable Gestures. When enabled in VRChat, the finger shapes set in the pose are kept even while you grip the controllers.

### Breathing

1. Turn on Features > Convenience > Animate breathing.
2. From Open settings, choose None, Weak, Medium, Strong, Rapid or Custom for each posture category. Adjust the strength in the category that matches the Virtual Love poses. Custom lets you assign your own breathing animation.
3. To stop and resume breathing in-game as well, also turn on Features > Menu features > Breathing. In VRChat, Breathing switches it ON/OFF.

Turn on Disable VRChat idle sway to suppress the default body sway that is added automatically while idle. The breathing set in the pose tool keeps working.

### Reducing pose distortion from head rotation

Turn on Features > Convenience > Reduce pose distortion from head rotation. Use it when releasing head lock distorts the body because the neck orientation differs from the original pose.

### Roll Over

Roll Over is a feature you use by preparing a matching lying pose and sideways animations.

1. Turn on Features > Menu features > Roll Over.
2. In Poses, open Details for the pose you want and turn on Enable roll over.
3. Assign the matching animations to Sideways roll-over pose and adjust Ground correction strength if needed.
4. In VRChat, choose that pose, release head lock and turn on Roll Over. Tilt your head left or right to roll over.

Poses that use roll over cannot use the regular MotionTime setting. The poses included in Virtual Love do not contain sideways roll-over animations, so prepare suitable motions if you want to use it.

## Parameter usage

Turning off features you do not need reduces ExpressionParameters usage.

| Feature | Additional usage |
| --- | --- |
| Mirror | 1 bit |
| Disable Gestures | 1 bit |
| Foot Height | 8 bit |
| Floor Height | 8 bit |
| Breathing motion | 0 bit |
| In-game breathing ON/OFF | 1 bit |
| Photo Mode (your own screen only) | 0 bit |
| Photo Mode sync | 16 bit |
| Head visibility while photographing | 0 bit |
| Reducing pose distortion from head rotation | 1 bit (shared with Roll Over) |
| Roll Over | 10 bit (1 bit of which is shared with the distortion reduction) |

Pose selection and other usage is added to these. Check the total in the Inspector. When several pose tools use the shared features, the shared part is not counted twice. Usage by other systems, such as outfits, is not included in this total.

## Checking and adjusting poses

Preview on each pose in Poses shows the posture in the Scene. Open Animation Adjustment to adjust the body direction and joints while previewing, then save the result.

The included poses are based on あのん（Anon） by こよりLab. Adjust contact points with your partner and similar details to suit the body shape and outfit.

Enable avatar correction under Avatar Setup corrects differences in initial joint angles and twist from the reference avatar. Prevent reverse knee bending suppresses knees bending backward. Open the detailed settings to adjust Minimum knee bend (degrees). Check the corrected appearance with Preview as well.

Searching pose names, adding several animations and changing the order are also done in Poses. Disable or delete the poses you do not need.

The quick preview does not run the MA and NDMF build, so also check the final result, including outfits and other systems, after building the avatar.

### Pose icon images

Turn on Generate pose icons under Features to add pose images to the in-game menu. The build takes longer by the time needed to generate the images. To save space, turn on Reduce icon size. Pose icons are not generated for Android.

### Presets

Choose a preset at the bottom of Avatar Setup. Apply this preset replaces the current pose settings, so save your adjustments before switching.

Adjustment animation files created with Animation Adjustment, and presets that use them, may be distributed and sold without individual permission from Unisaki Studio. Use this to share adjustment data for your own avatars, for example.

## Prebuild

Update prebuild saves the generated menus and animations so that avatar builds can reuse them and finish faster. Without a prebuild, the required data is generated during the regular build.

After changing poses or features, look at Check settings in the Inspector and update the prebuild if you use one. Hiding a warning does not update the generated result.

## Gifting

If you do not use it yourself, you may give either the male or the female edition to your partner as a gift. The person who receives it may use it only with the person who gave it.

## Usage notes

- This product was made as a joke item. Do not use it for harassment.
- Follow the VRChat Terms of Service and good manners when using it.
- Pose locking during full-body tracking is not supported.
- Manual adjustment may be needed depending on the avatar's body shape, outfit and modifications.
- When using it together with other posture-changing systems, check how the locks and pose switching behave. Avatar Setup > Integrate tracking locks with other tools may help.
- The creator accepts no responsibility for any disadvantage caused by using this tool.

## Terms of use

Use this product only after agreeing to its terms of use, which are written with the VN3 license.

[Virtual Love terms of use](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

🌐 [日本語 · English · Français · Italiano · 简体中文 · 繁體中文 · 한국어 · ไทย · Deutsch · Español · Português · Português (Brasil) · Русский · Українська · Polski · Nederlands · Svenska · Dansk · Suomi · Norsk · Čeština · Türkçe · Bahasa Indonesia · Tiếng Việt · हिन्दी · বাংলা · தமிழ் · తెలుగు · العربية · עברית](Documentation~/Localization/index.md)
