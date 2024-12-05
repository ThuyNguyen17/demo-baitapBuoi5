Sử dụng RichTextBox để thiết kế điều khiển hiện thị và nhập nội dung văn bản:
Sử dụng công cụ MenuStrip để tạo Hệ Thống và Định Dạng
Sử dụng công cụ ToolStrip để tạo thanh công cụ chứa các button và image như trên
2.1 Khi mới mở Form, thực hiện:
• Tạo dữ liệu cho ComboBox Font: chứa tất cả các Font chữ của hệ thống.
• Tạo dữ liệu cho ComboBox Size: chứa các giá trị từ 8 → 72.  (8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72)
• Tạo giá trị mặc định ban đầu là Font Tahoma, Size 14
2.2 Khi chọn Tạo văn bản mới (hoặc nhấn nút ): Xóa nội dung hiện có trên RichTextBox và tạo lại các giá trị mặc định như Font, Size, …
2.3 Khi chọn Mở tập tin (hoặc nhấn nút ): Hiển thị hộp thoại mở tập tin (OpenFileDialog) cho phép người dùng chọn tập tin văn bản (*.txt hoặc *.rtf) để mở.
2.4 Khi chọn Lưu nội dung văn bản (hoặc nhấn nút ): Lưu nội dung văn bản trên RichTextBox xuống tập tin.
✔ Nếu là văn bản mới và trước đó chưa lưu lần nào thì hiển thị hộp thoại lưu tập tin (SaveFileDialog) cho phép người dùng chọn thư mục cần lưu tập tin với kiểu tập tin cần lưu là *.rtf.
✔ Nếu là văn bản đã được mở trước đó thì thông báo cho người dùng lưu văn bản thành công.
2.5 
Nút in đậm: Khi chọn, tùy thuộc vào trạng thái của nút để xử lý nội dung của vùng văn bản đang được chọn có được in đậm hay không.
Nút in nghiêng: Khi chọn, tùy thuộc vào trạng thái của nút để xử lý nội dung của vùng văn bản đang được chọn có được in nghiêng hay không.
Nút gạch chân: Khi chọn, tùy thuộc vào trạng thái của nút để xử lý nội dung củavùng văn bản đang được chọn có được gạch dưới hay không.
