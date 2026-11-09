# 🛒 Smart Store Management System

> **Hệ thống Quản lý Bán hàng & Tồn kho cửa hàng bán lẻ** xây dựng trên nền tảng **ASP.NET Core 8.0 MVC** kết nối **SQL Server** thông qua **Entity Framework Core**.

---

## 📌 Giới thiệu dự án
Dự án được xây dựng nhằm giải quyết bài toán quản lý danh mục, hàng hóa và kiểm soát tồn kho cho các cửa hàng vừa và nhỏ. Web application tuân thủ kiến trúc **MVC (Model-View-Controller)** hiện đại, áp dụng **Entity Framework Core** để tương tác dữ liệu an toàn và tối ưu.

## 🛠 Công nghệ & Thư viện sử dụng
- **Backend:** C# (.NET 8.0 MVC)
- **Database / ORM:** SQL Server, Entity Framework Core 8.0
- **Frontend UI:** HTML5, Razor Views, Bootstrap 5, CSS3
- **Tools & Platform:** Visual Studio 2022, SSMS, Git, GitHub

---

## ✨ Tính năng chính
- 📦 **Quản lý Sản phẩm (Products Management):**
  - Xem danh sách sản phẩm trực quan.
  - Thêm mới, chỉnh sửa thông tin và xóa sản phẩm (CRUD).
  - Quản lý mã vạch (Barcode), giá bán và số lượng tồn kho.
- 🏷 **Quản lý Danh mục (Categories Management):** Phân loại sản phẩm theo từng nhóm hàng hóa.
- 🔍 **Cảnh báo tồn kho:** Hiển thị trạng thái cảnh báo trực quan cho các mặt hàng sắp hết.

---

## 📁 Cấu trúc thư mục dự án
```text
SmartStore.Web/
├── Controllers/         # Chứa ProductsController xử lý logic CRUD
├── Data/                # Chứa ApplicationDbContext kết nối SQL Server
├── Models/              # Các Entity (Product, Category) và Validation
├── Views/               # Giao diện Razor UI (Products, Shared Layout)
├── wwwroot/             # Static files (CSS, JS, Bootstrap)
├── appsettings.json     # Cấu hình Chuỗi kết nối Database (ConnectionStrings)
└── Program.cs           # Cấu hình Services & Routing của .NET 8
