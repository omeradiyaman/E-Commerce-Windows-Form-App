# Windows Forms E-Commerce Application

This project is an **e-commerce application** developed using **C# Windows Forms, ADO.NET, and MSSQL**. The system facilitates transactions between sellers and users, allowing them to manage products and orders efficiently.

## Technologies Used
- **C# Windows Forms** - Desktop application development
- **ADO.NET** - Database operations
- **MSSQL** - Database management

## System Features

### 🔹 Seller Features
- Add, update, and delete products
- Manage product stock levels
- Process and manage orders (e.g., preparing, shipping, confirming orders)

### 🔹 User Features
- Add products to the cart and purchase them
- Add products to the favorites list
- Make payments using a credit card (with email verification for security)
- Update profile information (address, phone number, etc.)
- Cancel orders if necessary

### 🔹 User Registration & Authentication
- Users receive a **verification code via email** when registering.
- To activate their accounts, they must enter this code during login.
- **Password reset** also requires email verification.

## How It Works
1. **User Registration & Verification**: 
   - New users register using their email addresses.
   - A verification code is sent to their email, which they must enter to complete the registration process.
2. **Password Reset**:
   - Users who forget their password can request a reset.
   - A verification code is sent to their email to confirm identity before setting a new password.
3. **Product Management**:
   - Sellers can add and update products with details like price, stock availability, and images.
   - Products can be categorized for easier browsing.
4. **Shopping Process**:
   - Users can browse and add products to their cart or favorites.
   - Once ready to purchase, they proceed to checkout and enter their credit card details.
   - A confirmation code is sent via email, which must be entered to complete the purchase.
5. **Order Tracking & Management**:
   - Sellers manage orders, changing their statuses (e.g., "Processing", "Shipped").
   - Users can track their orders and request cancellations if needed.
6. **User Profile & Settings**:
   - Users can update their profile information, including shipping addresses and contact details.

## Installation
1. Create an **MSSQL database** named `ECommerceDB`.
2. Update the **database connection string** in the `app.config` file.
3. Open the project in **Visual Studio** and run the application.

**USER
## Screenshots
(Screenshots can be added here to showcase the UI and functionality)
![Ekran görüntüsü 2025-03-18 121114](https://github.com/user-attachments/assets/abab0c09-ba1d-4514-8c79-cb2fa5f80682)
![Ekran görüntüsü 2025-03-18 121143](https://github.com/user-attachments/assets/8aa82c24-90fb-4c7b-a726-24b094b87272)
![Ekran görüntüsü 2025-03-18 121158](https://github.com/user-attachments/assets/a43227a0-b930-4ee1-9499-facf30e0e506)
![Ekran görüntüsü 2025-03-18 121236](https://github.com/user-attachments/assets/6d56259a-2fe7-4321-8034-4bc45abdc163)
![Ekran görüntüsü 2025-03-18 121246](https://github.com/user-attachments/assets/f281f661-4f3b-4eba-a688-4b514650cb5a)
![Ekran görüntüsü 2025-03-18 121325](https://github.com/user-attachments/assets/b999cb4b-e475-48b0-877d-df88a843c2a7)
![Ekran görüntüsü 2025-03-18 121256](https://github.com/user-attachments/assets/9c2feae8-7e5e-40d9-b0dd-20d8c90ad178)
![Ekran görüntüsü 2025-03-18 123039](https://github.com/user-attachments/assets/dd254816-0492-4fd6-a875-d9c957c8d434)
![Ekran görüntüsü 2025-03-18 122516](https://github.com/user-attachments/assets/016ca22b-431c-4c37-b6e0-5e7e3bc1313f)

#REGISTER
![Ekran görüntüsü 2025-03-18 121947](https://github.com/user-attachments/assets/401b197c-3c8c-47d6-8539-d7d68c88fd5e)
![Ekran görüntüsü 2025-03-18 122537](https://github.com/user-attachments/assets/8de50e8b-7df7-46ba-9632-4115c26bfd61)
![Ekran görüntüsü 2025-03-18 122615](https://github.com/user-attachments/assets/a5a92f79-bb82-4ca3-8860-b0cfb83e713c)

#ADMIN
![Ekran görüntüsü 2025-03-18 122756](https://github.com/user-attachments/assets/eacd4a54-8192-4d6b-a0e6-dced34899d3c)
![Ekran görüntüsü 2025-03-18 122815](https://github.com/user-attachments/assets/ea6e5dce-39c3-4f6c-bfc5-dee32ad13719)
![Ekran görüntüsü 2025-03-18 122822](https://github.com/user-attachments/assets/56f0496f-41d2-45f4-8268-b2fb2315df06)
![Ekran görüntüsü 2025-03-18 122843](https://github.com/user-attachments/assets/687c9a0c-0496-47d4-9d05-45fe234ec1e9)
![Ekran görüntüsü 2025-03-18 123553](https://github.com/user-attachments/assets/8f9228f1-1171-4dbe-8e60-72ed6fa31c84)
![Ekran görüntüsü 2025-03-18 122850](https://github.com/user-attachments/assets/c7782d6c-fa14-4515-afeb-12d0cc3a21bb)
![Ekran görüntüsü 2025-03-18 122946](https://github.com/user-attachments/assets/6e8ba5f7-99c3-4220-9e94-c404f7261f13)
![Ekran görüntüsü 2025-03-18 122937](https://github.com/user-attachments/assets/d86c5000-4631-4f6f-831b-5ac3874cc3e4)


#RELATIONS
![Ekran görüntüsü 2025-03-18 122354](https://github.com/user-attachments/assets/1c1172cb-2f63-4b11-885f-b2f037b20a3e)


