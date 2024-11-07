// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Học phép toán cơ bản
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là: {add}");

// int minus = 100-30;
// Console.WriteLine($"Kết quả phép trừ của 100 và 30 là: {minus}");

// double devide = 5 / 2;
// Console.WriteLine($"Kết quả phép chia của 5 và 2 là: {devide}");

#endregion

#region Numberic toán tử gán

// int cong = 0;
// cong += 10;
// Console.WriteLine ($"Numberic toán tử cộng: {cong}");

// int nhan = 500;
// nhan *= 2;
// Console.WriteLine ($"Numberic toán tử nhân:{nhan}");

#endregion

#region Ép (chuyển) kiểu dữ liệu - Dùng Convert

// Console.WriteLine ("Mời bạn nhập dữ liệu là số: ");
// string number = Console.ReadLine();
// int convertNumber = Convert.ToInt32(number);
// Console.WriteLine($"value number: {convertNumber}");

#endregion

#region  Tính chỉ số BIM
// // Input - nhập chiều cao, cân nặng được nhập từ bàn phím

// Console.WriteLine("Mời bạn nhập vào chỉ số chiều cao (m)");
// string? chieuCao = Console.ReadLine();
// // Convert string -> double
// double fomatChieuCao = Convert.ToDouble(chieuCao);
// Console.WriteLine("Mời bạn nhập cân nặng (kg)");
// string? canNang = Console.ReadLine();
// double fomatCanNang = Convert.ToDouble(canNang);

// // Output - In ra chỉ số BMI
// // Khởi tạo biến BMI để lưu giá trị BMI

// double bmi = 0.0;

// //PROCESS - Tính giá trị BMI = (Cân nặng) / (chiều cao*chiều cao}

// bmi = fomatCanNang / (fomatChieuCao*fomatChieuCao);
// Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");

    #endregion

 #region  Tính chu vi, diện tích
//Input
 // B1: Nhập bán kính từ bàn phím
//  Console.WriteLine("Mời bạn nhập bán kính hình tròn:");
//  string? banKinh = Console.ReadLine();
 //B2: Nhập kiểu dữ liệu string -> doule từ bàn phím
//  double formatbanKinh = Convert.ToDouble (banKinh);

// Output
// double dienTich =0.0;
// double chuVi = 0.0;

//Process
// chu vi = 2*Pi*bankinh
// dien tich = pi *bán kính*bán kính
// double PI = Math.PI;  //dùng hằng số PI có sẵn trong thư viện Math trong  C#
// chuVi = 2 * PI * formatbanKinh;
// dienTich = PI * formatbanKinh * formatbanKinh;
// Console.WriteLine($"Chu vi hình tròn là:{chuVi}");
// Console.WriteLine($"Diện tích hình tròn là: {dienTich}");

    #endregion

    