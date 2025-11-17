<img width="839" height="907" alt="image" src="https://github.com/user-attachments/assets/f7a2ba5c-d9f5-47f5-856b-91c777983b84" />

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
