# Kế hoạch kiểm thử hệ thống quản lý thư viện

## 1. Test-case Review Checklist

### 1.1 Mục đích của Test Case Review Checklist
- Đảm bảo tính đúng đắn và chính xác của test case
- Kiểm tra độ phủ của test case với các yêu cầu và kịch bản
- Phát hiện lỗi và thiếu sót trong test case
- Đảm bảo tính nhất quán và dễ hiểu

### 1.2 Quy trình Review Test Case
1. Chuẩn bị
   - Xác định tiêu chí và checklist
   - Chuẩn bị tài liệu liên quan

2. Thực hiện Review
   - Duyệt từng test case theo checklist
   - Ghi nhận lỗi và đề xuất cải tiến

3. Phản hồi và Sửa đổi
   - Gửi phản hồi cho người tạo test case
   - Yêu cầu sửa đổi nếu cần

4. Xác nhận và Chấp nhận
   - Kiểm tra lại các sửa đổi
   - Chấp nhận test case nếu đạt yêu cầu

### 1.3 Checklist đánh giá

| Câu hỏi | Có | Không | N/A | Độ ưu tiên |
|---------|-----|-------|-----|------------|
| **Kiểm soát tài liệu** |
| Trang tiêu đề có đầy đủ thông tin? | | | | Bắt buộc |
| Header và footer đúng định dạng? | | | | Bắt buộc |
| Đánh số trang rõ ràng? | | | | Bắt buộc |
| Lịch sử tài liệu có thể theo dõi? | | | | Bắt buộc |
| Có danh sách tài liệu tham khảo? | | | | Bắt buộc |
| Đã kiểm tra chính tả và ngữ pháp? | | | | Bắt buộc |

| **Nội dung Test Case** |
| Test case bao phủ đầy đủ yêu cầu? | | | | Bắt buộc |
| Test case bao phủ các kịch bản và ngoại lệ? | | | | Bắt buộc |
| Mục tiêu và kết quả mong đợi rõ ràng? | | | | Bắt buộc |
| Thông tin đầu vào đầy đủ? | | | | Bắt buộc |
| Kết quả mong đợi được xác định? | | | | Bắt buộc |
| Có kiểm tra điều kiện biên? | | | | Bắt buộc |
| Định dạng test case thống nhất? | | | | Bắt buộc |
| Mức độ ưu tiên rõ ràng? | | | | Bắt buộc |
| Liên kết với yêu cầu chức năng? | | | | Bắt buộc |
| Nội dung rõ ràng, dễ hiểu? | | | | Bắt buộc |
| Ngắn gọn, không thừa thãi? | | | | Bắt buộc |

## 2. Test Design

### 2.1 Quản lý sách

#### 2.1.1 Thêm sách mới

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Thêm sách thành công | Kiểm tra thêm sách với thông tin hợp lệ | Function | |
| Trùng mã sách | Kiểm tra thông báo lỗi khi mã sách đã tồn tại | Function | |
| Thiếu thông tin bắt buộc | Kiểm tra yêu cầu nhập đủ thông tin | Function | |
| Số lượng sách âm | Kiểm tra không cho phép nhập số lượng âm | Function | |
| Giá sách âm | Kiểm tra không cho phép nhập giá âm | Function | |

#### 2.1.2 Cập nhật thông tin sách

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Cập nhật thành công | Kiểm tra cập nhật thông tin hợp lệ | Function | |
| Không tìm thấy sách | Kiểm tra thông báo khi mã sách không tồn tại | Function | |
| Cập nhật mã sách | Kiểm tra không cho phép thay đổi mã sách | Function | |

#### 2.1.3 Xóa sách

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Xóa thành công | Kiểm tra xóa sách không có ràng buộc | Function | |
| Sách đang được mượn | Kiểm tra không cho phép xóa sách đang mượn | Function | |

### 2.2 Quản lý độc giả

#### 2.2.1 Thêm độc giả mới

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Thêm thành công | Kiểm tra thêm độc giả với thông tin hợp lệ | Function | |
| Trùng mã độc giả | Kiểm tra thông báo lỗi khi mã đã tồn tại | Function | |
| Thiếu thông tin bắt buộc | Kiểm tra yêu cầu nhập đủ thông tin | Function | |
| Email không hợp lệ | Kiểm tra định dạng email | Function | |
| SĐT không hợp lệ | Kiểm tra định dạng số điện thoại | Function | |

#### 2.2.2 Cập nhật thông tin độc giả

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Cập nhật thành công | Kiểm tra cập nhật thông tin hợp lệ | Function | |
| Không tìm thấy độc giả | Kiểm tra thông báo khi mã không tồn tại | Function | |
| Cập nhật mã độc giả | Kiểm tra không cho phép thay đổi mã | Function | |

#### 2.2.3 Xóa độc giả

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Xóa thành công | Kiểm tra xóa độc giả không có ràng buộc | Function | |
| Độc giả đang mượn sách | Kiểm tra không cho phép xóa độc giả đang mượn sách | Function | |

### 2.3 Quản lý mượn/trả sách

#### 2.3.1 Mượn sách

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Mượn thành công | Kiểm tra mượn sách với thông tin hợp lệ | Function | |
| Sách không tồn tại | Kiểm tra thông báo khi mã sách không tồn tại | Function | |
| Độc giả không tồn tại | Kiểm tra thông báo khi mã độc giả không tồn tại | Function | |
| Sách đã hết | Kiểm tra thông báo khi số lượng sách = 0 | Function | |
| Độc giả đã mượn quá số lượng cho phép | Kiểm tra giới hạn số sách mượn | Function | |

#### 2.3.2 Trả sách

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Trả thành công | Kiểm tra trả sách với thông tin hợp lệ | Function | |
| Không tìm thấy phiếu mượn | Kiểm tra thông báo khi không tìm thấy phiếu | Function | |
| Sách đã trả | Kiểm tra thông báo khi sách đã được trả | Function | |
| Quá hạn trả | Kiểm tra tính phí quá hạn | Function | |

### 2.4 Tìm kiếm và báo cáo

#### 2.4.1 Tìm kiếm sách

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Tìm theo mã sách | Kiểm tra tìm kiếm chính xác theo mã | Function | |
| Tìm theo tên sách | Kiểm tra tìm kiếm theo từ khóa | Function | |
| Tìm theo tác giả | Kiểm tra tìm kiếm theo tác giả | Function | |
| Tìm theo thể loại | Kiểm tra tìm kiếm theo thể loại | Function | |
| Không có kết quả | Kiểm tra thông báo khi không tìm thấy | Function | |

#### 2.4.2 Báo cáo

| Yêu cầu | Test Criteria | Loại test | Ghi chú |
|---------|---------------|-----------|---------|
| Báo cáo sách đang mượn | Kiểm tra danh sách sách đang mượn | Function | |
| Báo cáo sách quá hạn | Kiểm tra danh sách sách quá hạn | Function | |
| Báo cáo thống kê | Kiểm tra các báo cáo thống kê | Function | |

## 3. Thiết kế kiểm thử

### 3.1 Kiểm thử hộp đen (Black Box Testing)

| Stt | Chức năng | Dữ liệu đầu vào | Kết quả mong đợi | Ghi chú |
|-----|-----------|-----------------|------------------|---------|
| 1 | Thêm sách | Title: "Lập trình C#", Author: "John Doe", Description: "Sách về C#", PublicationYear: 2023 | Thêm thành công | Dữ liệu hợp lệ |
| 2 | Thêm sách | Title: "", Author: "", Description: "", PublicationYear: 1700 | Thêm không thành công | Kiểm tra validation |
| 3 | Thêm sách | Title: "A" x 256, Author: "B" x 101, Description: "C" x 1001 | Thông báo lỗi độ dài | Kiểm tra giới hạn ký tự |
| 4 | Thêm độc giả | Name: "Nguyễn Văn A", Email: "a@email.com", PhoneNumber: "0123456789" | Thêm thành công | Dữ liệu hợp lệ |
| 5 | Thêm độc giả | Name: "", Email: "invalid-email", PhoneNumber: "123" | Thêm không thành công | Kiểm tra validation |
| 6 | Thêm độc giả | Email: "a@email.com" x 256, PhoneNumber: "12345678901" | Thông báo lỗi độ dài | Kiểm tra giới hạn ký tự |
| 7 | Mượn sách | BookId: 1, ReaderId: 1, LoanDate: "2024-03-20" | Mượn thành công | Sách còn trong kho |
| 8 | Mượn sách | BookId: 1, ReaderId: 1, LoanDate: "2024-03-20" | Thông báo: Sách đã được mượn | Sách đã được mượn |
| 9 | Trả sách | LoanId: 1, ReturnDate: "2024-03-25" | Trả thành công | Trả đúng hạn |
| 10 | Trả sách | LoanId: 1, ReturnDate: "2024-04-20" | Trả thành công | Trả quá hạn |

### 3.2 Kiểm thử hộp trắng (White Box Testing)

| Stt | Dữ liệu vào | Nhánh kiểm thử | Kết quả |
|-----|-------------|----------------|---------|
| 1 | Title = null | Vào block validation Title | Thông báo: Vui lòng nhập tên sách |
| 2 | Title.Length > 255 | Vào block validation MaxLength | Thông báo: Tên sách không được vượt quá 255 ký tự |
| 3 | PublicationYear = 1700 | Vào block validation Range | Thông báo: Năm xuất bản phải từ 1800 đến 2100 |
| 4 | Email = "invalid-email" | Vào block validation EmailAddress | Thông báo: Địa chỉ email không hợp lệ |
| 5 | PhoneNumber = "123" | Vào block validation StringLength | Thông báo: Số điện thoại phải từ 10 đến 11 chữ số |
| 6 | PhoneNumber = "123abc" | Vào block validation RegularExpression | Thông báo: Số điện thoại chỉ được chứa chữ số |
| 7 | BookId = 0 | Vào block validation Required | Thông báo: Vui lòng chọn sách |
| 8 | ReaderId = 0 | Vào block validation Required | Thông báo: Vui lòng chọn độc giả |
| 9 | LoanDate = null | Vào block validation Required | Thông báo: Vui lòng chọn ngày mượn |
| 10 | ReturnDate < LoanDate | Vào block validation logic | Thông báo: Ngày trả phải sau ngày mượn |

## 4. Test Design Workflow

### 4.1 Quy trình kiểm thử

| Bước | Vai trò phụ trách |
|------|-------------------|
| Xác định yêu cầu & phạm vi | Tester Lead + BA |
| Thiết kế test-case | Tester |
| Review test-case | Tester Lead + Team |
| Chuẩn bị môi trường | Tester + DevOps |
| Thực thi test-case | Tester |
| Ghi nhận kết quả & log lỗi | Tester |
| Phân tích và chuyển lỗi | Tester Lead -> Developer |
| Sửa lỗi | Developer |
| Kiểm tra lại | Tester |
| Test hồi quy | Tester |
| Báo cáo kết quả | QA Lead |

### 4.2 Công cụ sử dụng
- Quản lý test case: TestRail
- Quản lý lỗi: Jira
- Tự động hóa test: Selenium WebDriver
- CI/CD: Jenkins

## 5. Kiểm thử thủ công

### 5.1 Quy trình kiểm thử thủ công
1. Đọc hiểu tài liệu yêu cầu
2. Thiết lập dữ liệu test
3. Thực thi test case theo thứ tự ưu tiên
4. Ghi chép kết quả
5. Báo cáo lỗi
6. Kiểm tra lại sau khi sửa

### 5.2 Tài liệu liên quan
- Test Plan
- Test Case Document
- Test Result Document
- Bug Reports

## 6. Unit Test

### 6.1 Các module cần unit test
- Models
- Controllers
- Services
- Repositories

### 6.2 Công cụ unit test
- xUnit
- Moq (mocking framework)
- FluentAssertions

### 6.3 Ví dụ unit test

```csharp
[Fact]
public void AddBook_WithValidData_ShouldSucceed()
{
    // Arrange
    var book = new Book
    {
        Code = "B001",
        Title = "Test Book",
        Author = "Test Author",
        Quantity = 5,
        Price = 100
    };

    // Act
    var result = _bookService.AddBook(book);

    // Assert
    Assert.True(result.Success);
    Assert.Equal("B001", result.Data.Code);
}

[Fact]
public void AddBook_WithDuplicateCode_ShouldFail()
{
    // Arrange
    var existingBook = new Book { Code = "B001" };
    _bookRepository.Add(existingBook);

    var newBook = new Book
    {
        Code = "B001",
        Title = "Another Book"
    };

    // Act
    var result = _bookService.AddBook(newBook);

    // Assert
    Assert.False(result.Success);
    Assert.Contains("duplicate", result.Message.ToLower());
}
```

## 7. Defect Log & Bug Report

### 7.1 Mẫu Defect Log

| Bug ID | Mô tả | Bước tái hiện | Mức độ | Trạng thái | Người phụ trách |
|--------|-------|---------------|--------|------------|-----------------|
| BUG001 | Lỗi thêm sách trùng mã | 1. Thêm sách mã B001<br>2. Thêm sách khác cùng mã | Nghiêm trọng | Đang sửa | Dev A |
| BUG002 | Lỗi hiển thị giá sách | 1. Xem chi tiết sách | Nhỏ | Đã sửa | Dev B |

### 7.2 Mẫu Bug Report

**ID:** BUG001
**Title:** [Book Management] Lỗi thêm sách trùng mã
**Environment:** Test server, SQL Server 2019
**Severity:** Critical
**Priority:** High
**Description:** Hệ thống cho phép thêm sách mới với mã sách đã tồn tại
**Steps to Reproduce:**
1. Đăng nhập với quyền admin
2. Thêm sách mới với mã "B001"
3. Thêm sách khác với cùng mã "B001"
**Expected Result:** Hệ thống hiển thị thông báo lỗi "Mã sách đã tồn tại"
**Actual Result:** Hệ thống cho phép thêm sách và tạo bản ghi trùng lặp
**Attachments:** Screenshot lỗi
**Reported by:** Tester A
**Assigned to:** Developer B
**Status:** Open

## 8. Tổng kết kiểm thử

### 8.1 Kết quả kiểm thử

| Loại test | Số TC | Pass | Fail | Bỏ qua |
|-----------|-------|------|------|---------|
| Chức năng | 20 | 18 | 2 | 0 |
| Phi chức năng | 5 | 4 | 1 | 0 |
| Giao diện | 3 | 3 | 0 | 0 |
| Hiệu năng | 2 | 2 | 0 | 0 |
| Bảo mật | 2 | 2 | 0 | 0 |
| **Tổng cộng** | **32** | **29** | **3** | **0** |

### 8.2 Kết luận
- Hệ thống đáp ứng 90.6% test case (29/32)
- Các lỗi nghiêm trọng đã được sửa hoặc có kế hoạch sửa
- Yêu cầu chức năng cốt lõi hoạt động đúng
- Yêu cầu phi chức năng đạt yêu cầu
- Độ ổn định tốt sau khi sửa lỗi

### 8.3 Đề xuất
- Tiến hành UAT với người dùng thực tế
- Chuẩn bị triển khai chính thức
- Lên kế hoạch phát triển tính năng mới 

## 9. Kế hoạch phát triển hệ thống (10 tuần)

### Tuần 1: Phân tích yêu cầu và thiết kế
- **Phân tích yêu cầu**
  - Thu thập yêu cầu từ người dùng
  - Xác định các chức năng chính
  - Xác định các ràng buộc và yêu cầu phi chức năng

- **Thiết kế hệ thống**
  - Thiết kế cơ sở dữ liệu
  - Thiết kế kiến trúc hệ thống
  - Thiết kế giao diện người dùng

### Tuần 2: Thiết lập môi trường và cấu trúc dự án
- **Thiết lập môi trường phát triển**
  - Cài đặt .NET Core
  - Cài đặt SQL Server
  - Cài đặt các công cụ phát triển

- **Tạo cấu trúc dự án**
  - Tạo project ASP.NET Core MVC
  - Thiết lập Entity Framework Core
  - Tạo các thư mục Models, Views, Controllers

### Tuần 3: Phát triển module Quản lý sách
- **Phát triển model Book**
  - Tạo entity Book
  - Thêm các validation
  - Tạo migration

- **Phát triển chức năng CRUD sách**
  - Tạo BookController
  - Tạo các view cho thêm, sửa, xóa, danh sách
  - Thêm validation và xử lý lỗi

### Tuần 4: Phát triển module Quản lý độc giả
- **Phát triển model Reader**
  - Tạo entity Reader
  - Thêm các validation
  - Tạo migration

- **Phát triển chức năng CRUD độc giả**
  - Tạo ReaderController
  - Tạo các view cho thêm, sửa, xóa, danh sách
  - Thêm validation và xử lý lỗi

### Tuần 5: Phát triển module Mượn/Trả sách
- **Phát triển model Loan**
  - Tạo entity Loan
  - Thêm các validation
  - Tạo migration

- **Phát triển chức năng mượn/trả sách**
  - Tạo LoanController
  - Tạo các view cho mượn, trả sách
  - Thêm validation và xử lý lỗi

### Tuần 6: Phát triển module Tìm kiếm và Báo cáo
- **Phát triển chức năng tìm kiếm**
  - Tìm kiếm sách
  - Tìm kiếm độc giả
  - Tìm kiếm phiếu mượn

- **Phát triển chức năng báo cáo**
  - Báo cáo sách đang mượn
  - Báo cáo sách quá hạn
  - Báo cáo thống kê

### Tuần 7: Phát triển giao diện người dùng
- **Thiết kế giao diện**
  - Tạo layout chung
  - Thiết kế các form
  - Thêm CSS và JavaScript

- **Tối ưu trải nghiệm người dùng**
  - Thêm validation phía client
  - Thêm thông báo
  - Tối ưu hiệu suất

### Tuần 8: Kiểm thử
- **Kiểm thử đơn vị**
  - Viết unit test cho models
  - Viết unit test cho controllers
  - Kiểm tra độ phủ code

- **Kiểm thử tích hợp**
  - Kiểm thử các luồng nghiệp vụ
  - Kiểm thử tích hợp với database
  - Kiểm thử hiệu suất

### Tuần 9: Sửa lỗi và tối ưu
- **Sửa lỗi**
  - Sửa các lỗi phát hiện trong quá trình kiểm thử
  - Tối ưu code
  - Cải thiện hiệu suất

- **Tối ưu hệ thống**
  - Tối ưu truy vấn database
  - Tối ưu giao diện
  - Thêm caching

### Tuần 10: Triển khai và bàn giao
- **Chuẩn bị triển khai**
  - Tạo tài liệu hướng dẫn
  - Chuẩn bị môi trường production
  - Backup dữ liệu

- **Triển khai và bàn giao**
  - Triển khai lên server
  - Kiểm tra hệ thống
  - Bàn giao cho người dùng

### Kết quả đạt được sau 10 tuần
1. Hệ thống quản lý thư viện hoàn chỉnh
2. Tài liệu hướng dẫn sử dụng
3. Mã nguồn được tối ưu và kiểm thử
4. Database được thiết kế và triển khai
5. Giao diện người dùng thân thiện
6. Các chức năng chính:
   - Quản lý sách
   - Quản lý độc giả
   - Mượn/trả sách
   - Tìm kiếm và báo cáo
