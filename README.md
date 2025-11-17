CodeForge_Winform/
│
├── Presentation/                     # 🖥️ Tầng giao diện (UI)
│   ├── Forms/
│   │   ├── MainForm.cs
│   │   ├── LoginForm.cs
│   │   └── UserForm.cs
│   ├── Controls/                     # Custom user controls (tùy chọn)
│   └── Helpers/                      # MessageBox, UIUtil,...
│
├── Business/                         # ⚙️ Tầng xử lý nghiệp vụ
│   ├── Interfaces/
│   │   ├── IUserService.cs
│   ├── Services/
│   │   ├── UserService.cs
│   └── Models/                       # DTO / ViewModel
│       ├── UserModel.cs
│
├── DataAccess/                       # 🗄️ Tầng làm việc với DB
│   ├── Entities/
│   │   └── UserEntity.cs
│   ├── Repositories/
│   │   ├── IUserRepository.cs
│   │   └── UserRepository.cs
│   └── Database/
│       └── DatabaseHelper.cs         # Kết nối DB (ADO.NET/Dapper)
│
├── Common/                           # 🧰 Dùng chung
│   ├── Helpers/
│   │   └── PasswordHelper.cs
│   └── Config/
│       └── AppSettings.cs
│
├── App.config                        # ConnectionString, config khác
├── Program.cs                        # Main()
└── CodeForge_Winform.sln

1️⃣ Presentation (UI Layer)

Chỉ chứa Form và xử lý giao diện.

Tương tác với tầng Business (gọi service → nhận data → hiển thị).

Không chứa logic hoặc truy vấn SQL.

2️⃣ Business (Business Logic Layer)

Chứa toàn bộ logic của ứng dụng.

Validate dữ liệu, kiểm tra điều kiện, xử lý luồng nghiệp vụ.

Gọi xuống Repository để lấy/tải dữ liệu từ DB.

3️⃣ DataAccess (Data Layer)

Làm việc trực tiếp với DB: query, insert, update.

Repository pattern để tách biệt logic truy vấn.

Entities mapping với bảng SQL.

4️⃣ Common (Shared utilities)

Các helper dùng chung nhiều nơi.

Config, constants, password hash, v.v.
