# Virtual Love

Công cụ cho avatar VRChat, giúp bạn tận hưởng các tư thế ghép đôi cùng đối phương khi dùng theo dõi 3 điểm hoặc chế độ máy tính. Có 22 tư thế cho mỗi bên nam và nữ, tổng cộng 44 tư thế. Bạn cũng có thể thực hiện xoạc chân đứng và thử thách Jack-O.

README này dành cho v3.2.0 đang phát triển. Chưa xác định ngày phát hành chính thức. Xem phiên bản đã cài ở đầu Inspector.

- [Trang sản phẩm BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Lịch sử thay đổi](CHANGELOG.md)

## Ngôn ngữ hiển thị và tài liệu ngoại tuyến

Chọn ngôn ngữ hiển thị bằng “Language / 言語” ở đầu Inspector. Một lựa chọn áp dụng cho cả Inspector và menu VRChat được tạo. Tải avatar lên lại để thay đổi ngôn ngữ trong trò chơi.

Nếu chưa chọn, hệ thống dùng ngôn ngữ máy tính; ngôn ngữ không được hỗ trợ sẽ dùng tiếng Anh. Hỗ trợ Windows, macOS và Linux. Ngôn ngữ chọn gần nhất được lưu trong EditorPrefs và dùng cho các dự án khác của cùng người dùng hệ điều hành trên máy này. Tất cả công cụ tạo dáng và avatar dùng chung một ngôn ngữ. Thay đổi trong Inspector của bất kỳ công cụ nào sẽ cập nhật tùy chọn chung; lựa chọn ngôn ngữ riêng của từng avatar không được sử dụng. Không đồng bộ sang máy khác. Cách lưu giấy phép không thay đổi. Nút ngôn ngữ chỉ xuất hiện ở bước xác nhận cài đặt đầu tiên khi chưa lưu ngôn ngữ. Các lần đổi ngôn ngữ sau được thực hiện trong Inspector.

Bạn có thể chọn README và lịch sử thay đổi từ [danh sách ngôn ngữ](../index.html) đi kèm. “Hướng dẫn” và “Xem thay đổi” trong Inspector cũng theo ngôn ngữ đã chọn. Tên các tư thế đi kèm và tên phân loại của menu trong trò chơi cũng hiển thị bằng ngôn ngữ đã chọn. Điều khoản sử dụng vẫn được đính kèm bằng tiếng Nhật như trước.

## Cách cài đặt

1. Nhập “VirtualLove_Boy.unitypackage” hoặc “VirtualLove_Girl.unitypackage” đi kèm trong tệp đã mua vào Unity.
2. Sau khi đăng ký nguồn phát hành gói, bạn có thể thêm Virtual Love vào dự án cần dùng từ VCC hoặc ALCOM. Cần có Unisaki Posing System 3.2.0.
3. Trong Hierarchy, nhấp chuột phải vào avatar muốn cài rồi chọn “Unisaki Studio > Thêm Virtual Love (Nam)” hoặc “Unisaki Studio > Thêm Virtual Love (Nữ)”.
4. Chọn “三点だいしゅき(男)” hoặc “三点だいしゅき(女)” vừa được thêm vào trong avatar, rồi thiết lập tính năng và tư thế sẽ dùng trong Inspector.
5. Kiểm tra tư thế bằng xem trước, rồi tải avatar lên như bình thường.

Yêu cầu Unity 2022.3, VRChat Avatars SDK 3.10.4 trở lên, Modular Avatar dòng 1.x phiên bản 1.15.1 trở lên và NDMF dòng 1.x phiên bản 1.14.0 trở lên. Cập nhật các gói cần thiết cùng nhau qua VCC hoặc ALCOM.

## Cập nhật từ phiên bản cũ

Cập nhật sản phẩm và Unisaki Posing System cùng nhau. Thiết lập của công cụ đã đặt được giữ. Kiểm tra tính năng và mức dùng ExpressionParameters trong Inspector; nếu từng dùng tạo trước, nhấn “Cập nhật dữ liệu tạo trước” rồi tải lên lại.

## Vị trí thiết lập

| Thẻ | Thiết lập chính |
| --- | --- |
| Tính năng | Thêm menu trong trò chơi, chế độ chụp, thở, ảnh biểu tượng và kiểm tra mức dùng tham số |
| Tư thế | Tư thế sử dụng, tìm kiếm, thêm, sắp xếp, xem trước và hiệu chỉnh hoạt ảnh |
| Thiết lập avatar | Hiệu chỉnh cơ thể, nhập tư thế gốc và chuyển động tự tạo, thiết lập sẵn |

Hãy bật các tính năng cần thiết trước khi tải lên. Mục nào có “Mở thiết lập” thì có thể hiển thị thiết lập chi tiết ngay bên dưới.

## Điều khiển cơ bản trong trò chơi

Mở menu Expressions và chọn một tư thế của Virtual Love. Hãy chọn các tư thế ghép đôi giữa bên nam và bên nữ, rồi căn vị trí và hướng với đối phương.

Bạn có thể bật/tắt khóa đầu, tay và chân để điều chỉnh phần cơ thể bám theo chuyển động của mình. Khi dùng “Khóa chân”, bạn có thể cử động đầu trong khi vẫn giữ tư thế phía chân. Nếu muốn lật đối xứng hoặc chỉnh độ cao của tư thế, hãy bật trước các tính năng tương ứng trong Unity.

### Chế độ chụp

Bạn có thể di chuyển avatar của mình đến vị trí nhìn thấy được, chỉnh hướng rồi chụp ảnh.

1. Bật “Tính năng > Tính năng menu > Chế độ chụp” trong Unity.
2. Trong VRChat, mở “Chế độ chụp” và chọn tư thế muốn dùng bằng “Chọn tư thế”.
3. Dùng “Khoảng cách” để đưa avatar về phía trước tối đa 3m. Khi khoảng cách lớn hơn 0, avatar sẽ quay về phía bạn.
4. Xoay bằng “Hướng”; khi đã chọn được vị trí, bật “Khóa chân” nếu cần. Chân không tự khóa lúc bắt đầu, nên có thể chỉnh vị trí trước khi khóa.
5. Chụp xong, nhấn “Thoát chụp”. Khoảng cách và hướng được đặt lại, khóa chân được mở.

Nếu đã thêm “Tắt cử chỉ” vào menu, bạn cũng có thể đổi hình bàn tay ngay trong chế độ chụp.

Khi chỉ đổi vị trí và hướng trên màn hình của riêng bạn, chế độ chụp không dùng tham số đồng bộ. Nếu muốn người khác cũng thấy cùng vị trí và hướng, hãy bật “Tính năng > Tiện ích > Đồng bộ chế độ chụp” trong Unity.

Nếu đầu của chính bạn bị ẩn khi đến gần khiến khó chụp, hãy bật “Giữ đầu hiển thị trong chế độ chụp”. Thiết lập này áp dụng cho màn hình của bạn trong lúc chụp và trở lại hiển thị bình thường sau khi kết thúc.

### Độ cao chân và Độ cao sàn

Khi bật các mục muốn dùng trong “Tính năng > Tính năng menu” của Unity, chúng sẽ được thêm vào menu “Cài đặt” trong VRChat.

- **Độ cao chân**: chỉnh độ cao phía chân trong khi giữ nguyên vị trí đầu. Dùng khi chân bị chìm xuống sàn hoặc lơ lửng, hay khi muốn khớp độ cao với đối phương.
- **Độ cao sàn**: di chuyển toàn thân, gồm cả đầu, lên xuống. 50% là độ cao gốc, 0% là thấp hơn 3m, 100% là cao hơn 3m. Muốn trở về như cũ, hãy đưa về khoảng 50%.

Kết hợp với chế độ chụp, bạn có thể chỉnh độ cao, khoảng cách và hướng của avatar. Di chuyển/xoay của chế độ chụp và độ cao sàn cũng hiệu chỉnh cả chuyển động mặc định và chuyển động tùy chỉnh khi chưa chọn tư thế. Hãy kiểm tra góc nhìn trong VRChat và hành vi sau khi chuyển động mặc định bị thay thế trên thiết bị thực.

### Lật đối xứng và Tắt cử chỉ

- **Lật đối xứng**: bật “Tính năng > Tính năng menu > Lật đối xứng”, rồi đổi trái phải của tư thế bằng menu VRChat.
- **Tắt cử chỉ**: bật “Tính năng > Tính năng menu > Tắt cử chỉ”. Khi bật trong VRChat, hình ngón tay đã đặt trong tư thế vẫn được giữ ngay cả khi bạn nắm tay cầm điều khiển.

### Thở

1. Bật “Tính năng > Tiện ích > Thêm hoạt ảnh thở”.
2. Qua “Mở thiết lập”, chọn “Không, Nhẹ, Vừa, Mạnh, Nhanh, Tùy chỉnh” cho từng loại tư thế. Hãy chỉnh cường độ ở loại tương ứng với các tư thế của Virtual Love. “Tùy chỉnh” cho phép chỉ định hoạt ảnh thở do bạn tự chuẩn bị.
3. Nếu muốn dừng và tiếp tục thở ngay trong trò chơi, hãy bật thêm “Tính năng > Tính năng menu > Thở”. Trong VRChat, dùng “Thở” để chuyển ON/OFF.

Bật “Tắt đung đưa khi đứng yên của VRChat” để giảm đung đưa cơ thể mặc định tự động xuất hiện khi chờ. Hoạt ảnh thở đã thiết lập trong công cụ tư thế vẫn dùng được như cũ.

### Giảm méo tư thế do hướng đầu

Bật “Tính năng > Tiện ích > Giảm méo tư thế do xoay đầu”. Dùng khi mở khóa đầu mà tư thế cơ thể bị méo do hướng đầu khác với tư thế gốc.

### Lật người

Lật người là tính năng dùng được khi bạn chuẩn bị tư thế nằm tương ứng và các hoạt ảnh nằm nghiêng.

1. Bật “Tính năng > Tính năng menu > Lật người”.
2. Trong “Tư thế”, mở “Chi tiết” của tư thế muốn dùng và bật “Bật lật người”.
3. Chỉ định hoạt ảnh tương ứng cho “Tư thế lật người sang bên”, và điều chỉnh “Cường độ hiệu chỉnh sàn” khi cần.
4. Trong VRChat, chọn tư thế tương ứng, mở khóa đầu rồi bật “Lật người”. Nghiêng đầu sang trái hoặc phải để lật người.

Tư thế dùng lật người không dùng được thiết lập MotionTime thông thường. Các tư thế đi kèm Virtual Love không có sẵn hoạt ảnh nằm nghiêng để lật người, nên nếu muốn dùng, hãy tự chuẩn bị chuyển động phù hợp.

## Mức dùng tham số

Tắt các tính năng không cần thiết sẽ giảm mức dùng ExpressionParameters.

| Tính năng | Mức dùng thêm |
| --- | --- |
| Lật đối xứng | 1 bit |
| Tắt cử chỉ | 1 bit |
| Độ cao chân | 8 bit |
| Độ cao sàn | 8 bit |
| Hoạt ảnh thở | 0 bit |
| ON/OFF thở trong trò chơi | 1 bit |
| Chế độ chụp (chỉ màn hình của bạn) | 0 bit |
| Đồng bộ chế độ chụp | 16 bit |
| Hiển thị đầu khi chụp | 0 bit |
| Giảm méo tư thế do hướng đầu | 1 bit (dùng chung với Lật người) |
| Lật người | 10 bit (trong đó 1 bit dùng chung với giảm méo tư thế) |

Ngoài các mức trên còn có mức dùng cho việc chọn tư thế và các phần khác. Hãy kiểm tra tổng trong Inspector. Khi nhiều công cụ tư thế dùng các tính năng chung, phần dùng chung không bị tính hai lần. Mức dùng của các công cụ khác, chẳng hạn trang phục, không nằm trong tổng này.

## Kiểm tra và điều chỉnh tư thế

Nút “Xem trước” ở từng tư thế trong “Tư thế” cho phép hiển thị tư thế trong Scene. Mở “Hiệu chỉnh hoạt ảnh” để vừa xem trước vừa chỉnh hướng cơ thể và các khớp, rồi lưu lại.

Các tư thế đi kèm được tạo dựa trên “あのん（Anon）” của こよりLab. Hãy điều chỉnh vị trí tiếp xúc với đối phương và các chi tiết tương tự cho phù hợp với vóc dáng và trang phục.

“Bật hiệu chỉnh avatar” trong “Thiết lập avatar” giúp hiệu chỉnh khác biệt về góc khớp ban đầu và độ xoắn so với avatar chuẩn. “Ngăn đầu gối gập ngược” hạn chế đầu gối gập ngược chiều. Mở thiết lập chi tiết để chỉnh “Độ gập đầu gối tối thiểu (độ)”. Hãy kiểm tra cả hình dáng khi bật hiệu chỉnh bằng xem trước.

Tìm theo tên tư thế, thêm nhiều hoạt ảnh và đổi thứ tự cũng thực hiện trong “Tư thế”. Hãy tắt hoặc xóa các tư thế không cần.

Xem trước đơn giản không chạy quy trình dựng MA và NDMF, nên hãy kiểm tra cả trạng thái cuối cùng, gồm trang phục và các công cụ khác, sau khi dựng avatar.

### Ảnh biểu tượng tư thế

Bật “Tạo biểu tượng tư thế” trong “Tính năng” để gắn ảnh tư thế vào menu trong trò chơi. Thời gian dựng sẽ tăng thêm tương ứng với việc tạo ảnh. Nếu muốn giảm dung lượng, hãy bật “Giảm kích thước biểu tượng”. Biểu tượng tư thế không được tạo cho Android.

### Thiết lập sẵn

Bạn có thể chọn thiết lập sẵn ở cuối “Thiết lập avatar”. “Áp dụng thiết lập sẵn này” sẽ thay thế thiết lập tư thế hiện tại, nên hãy lưu nội dung đã chỉnh trước khi chuyển.

Các tệp hoạt ảnh hiệu chỉnh tạo bằng tính năng hiệu chỉnh hoạt ảnh, cùng các thiết lập sẵn dùng những tệp đó, có thể được phân phối và bán mà không cần Unisaki Studio cấp phép riêng. Chẳng hạn, bạn có thể dùng để chia sẻ dữ liệu hiệu chỉnh cho avatar tự làm.

## Tạo trước

Khi lưu kết quả tạo menu và hoạt ảnh bằng “Cập nhật dữ liệu tạo trước”, chúng được dùng lại lúc dựng avatar để xử lý nhanh hơn. Dù không tạo trước, dữ liệu cần thiết vẫn được tạo khi dựng thông thường.

Sau khi thay đổi tư thế hoặc tính năng, hãy xem “Kiểm tra thiết lập” trong Inspector và cập nhật nếu đang dùng tạo trước. Ẩn cảnh báo không làm cập nhật kết quả đã tạo.

## Về việc tặng quà

Nếu không tự sử dụng, bạn có thể tặng bản dành cho nam hoặc bản dành cho nữ cho người yêu của mình. Người được tặng chỉ có thể sử dụng cùng với người đã tặng.

## Lưu ý sử dụng

- Sản phẩm này được tạo ra với mục đích vui đùa. Vui lòng không dùng cho hành vi quấy rối.
- Hãy tuân thủ điều khoản dịch vụ và phép lịch sự của VRChat khi sử dụng.
- Không hỗ trợ khóa tư thế khi đang theo dõi toàn thân.
- Tùy vóc dáng, trang phục và nội dung chỉnh sửa của avatar, có thể cần điều chỉnh thủ công.
- Khi dùng chung với công cụ đổi tư thế khác, hãy kiểm tra hoạt động của các khóa và việc chuyển tư thế. Một số trường hợp có thể điều chỉnh bằng “Thiết lập avatar > Tích hợp khóa theo dõi với công cụ khác”.
- Tác giả không chịu trách nhiệm về bất kỳ thiệt hại nào phát sinh do sử dụng công cụ này.

## Điều khoản sử dụng

Vui lòng sử dụng sản phẩm này sau khi đồng ý với điều khoản sử dụng được soạn theo giấy phép VN3.

[Điều khoản sử dụng của Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)
