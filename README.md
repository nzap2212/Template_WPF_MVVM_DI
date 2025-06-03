# 🏥 HospitalIT WPF App Template – README Sử Dụng & Chuẩn Hóa

---

## 🎯 **HƯỚNG DẪN CHUẨN HÓA SETUP PROJECT**

### 1. **Clone & Đổi Tên Solution/Project**

#### **Bước 1: Clone repo template về máy**
```bash
git clone https://github.com/your-org/wpf-hospital-template.git
cd wpf-hospital-template
```

#### **Bước 2: Đổi tên Solution/Project/Namespace bằng script**
- Copy toàn bộ folder template sang thư mục mới (giữ lại bản gốc để backup).
- Mở PowerShell tại thư mục vừa copy.
- Chạy script:
    ```powershell
    .\Rename-Solution.ps1 -OldName "TemplateApp" -NewName "TomTatBenhAn"
    ```
  - **Lưu ý:**  
    - Thay `TemplateApp` = tên gốc của template (ví dụ: `WpfTemplate`).
    - Thay `TomTatBenhAn` = tên app mới theo bảng bên dưới.
- Script sẽ tự động:
    - Đổi tên folder, file, namespace, solution, project.
    - Thay đổi tất cả tên cũ thành tên mới trong toàn bộ code/config.

---

### 2. **Quy tắc đặt tên chuẩn cho mọi app**

| Display Name         | App ID     | Folder Name       | Exe Name            | MSI Name                       |
|----------------------|------------|-------------------|---------------------|-------------------------------|
| Tóm tắt bệnh án      | TD-UB-01   | TomTatBenhAn      | TomTatBenhAn.exe    | TomTatBenhAn_1.0.0_Setup.msi  |
| Quản lý bệnh nhân    | QL-BN-01   | QuanLyBenhNhan    | QuanLyBenhNhan.exe  | QuanLyBenhNhan_1.0.0_Setup.msi|
| Báo cáo thống kê     | BC-TK-01   | BaoCaoThongKe     | BaoCaoThongKe.exe   | BaoCaoThongKe_1.0.0_Setup.msi |

- **Lưu ý:** Tất cả tên không dấu, PascalCase, ngắn gọn, duy nhất cho từng app.

#### **Cấu trúc thư mục cài đặt CHUẨN:**
```
C:\Program Files (x86)\HospitalIT\
└── TomTatBenhAn\
    ├── TomTatBenhAn.exe
    ├── TomTatBenhAn.exe.config
    ├── Libs\
    ├── Data\
    └── Resources\
```

---

### 3. **Cấu hình Setup Project Properties**

#### **Application Information**
| Property           | Value (VD: TomTatBenhAn)          |
|--------------------|-----------------------------------|
| Product Name       | TomTatBenhAn                      |
| Manufacturer       | HospitalIT                        |
| Product Version    | 1.0.0                             |
| Title              | TomTatBenhAn Setup                |
| Subject            | Hospital Patient Summary App      |
| DefaultLocation    | [ProgramFilesFolder][Manufacturer]\[ProductName] |
| InstallAllUsers    | True                              |
| UpgradeCode        | {GUID}                            |

---

#### **QUAN TRỌNG: Registry Settings**
Vào **Setup Project** → View → Registry  
Thêm:
```
HKEY_LOCAL_MACHINE\SOFTWARE\HospitalIT\TomTatBenhAn
    InstallLocation (String)   = [TARGETDIR]
    ExecutablePath (String)    = [TARGETDIR]TomTatBenhAn.exe
    Version (String)           = [ProductVersion]
    DisplayName (String)       = Tóm tắt bệnh án
    AppId (String)             = TD-UB-01
```
- **NOTE:**  
  - Đổi “TomTatBenhAn” và giá trị tương ứng cho từng app theo bảng đặt tên.
  - Không chỉnh tên Manufacturer (luôn là **HospitalIT**).

---

#### **Start Menu Shortcuts**
```
Programs Menu > HospitalIT > Tóm tắt bệnh án
  - Target: [TARGETDIR]TomTatBenhAn.exe
  - Name: Tóm tắt bệnh án
  - Description: Ứng dụng tóm tắt bệnh án
```

---

### 4. **Checklist cuối cùng (NHỚ KIỂM TRA!):**
- [ ] Tên Solution, Project, Namespace đã đổi hết chưa?
- [ ] Thư mục, exe, config đúng format chưa?
- [ ] Setup project đã config đúng registry/key chưa?
- [ ] Đặt đúng DisplayName/AppId/MSI/Exe chưa?
- [ ] Đã rebuild, test, kiểm thử trên máy trắng?

---

### **💡 Nhắc nhở thơ:**
> Clone template, rename thần sầu  
> Setup registry, chuẩn đâu vào đấy  
> Tên chuẩn, folder gọn, sếp khen hay  
> Bệnh viện triển khai, khỏi lo lỗi lặt vặt.

---
