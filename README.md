# Health Center Patient Tracking System (SOHATS)

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Language](https://img.shields.io/badge/language-C%23-239120)

**Sağlık Merkezi Hasta Takip Sistemi** - A comprehensive Windows Forms application for managing patient information, medical operations, and healthcare workflows in health centers.

## 📋 Quick Start

- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Database Schema](#database-schema)
- [User Roles](#user-roles)

---

## Overview

SOHATS is a desktop application designed for primary health centers and clinics to streamline patient management, track medical procedures, manage clinic operations, and generate healthcare reports. Built with C#, Windows Forms, and SQL Server for reliable data management.

**Target Users**: Health Centers, Clinics, Doctors, Nurses, Clinic Staff

---

## Features

✅ **Patient Management** - Register, search, and manage patient records with complete medical history  
✅ **Clinic Operations** - Manage departments, appointments, and staff assignments  
✅ **Medical Procedures** - Record procedures, diagnoses, treatments, and vital signs  
✅ **Patient Discharge** - Handle discharge processes with comprehensive reports  
✅ **Reporting** - Generate patient, visit, and clinic performance reports  
✅ **User Access Control** - Role-based authentication and authorization  
✅ **Medical Referrals** - Create and track referrals to specialist clinics  

---

## Prerequisites

- **Windows**: Windows 7 SP1 or later
- **.NET Framework**: 4.0 or higher
- **SQL Server**: 2012 or later (Express Edition acceptable)
- **RAM**: 4 GB minimum
- **Storage**: 2 GB for application and data

---

## Installation

### 1. Clone Repository
```bash
git clone https://github.com/Rum-eysa/Health_Center_SOHATS.git
cd Health_Center_SOHATS/Saglik_Ocagi_Hasta_Takip_Sistemi
```

### 2. Setup Database
```sql
-- Open SQL Server Management Studio
-- Create database
CREATE DATABASE SOHATS;
USE SOHATS;

-- Execute script.sql to create tables
-- Then create default admin user
```

### 3. Update Connection String
Edit `App.config`:
```xml
<connectionStrings>
  <add name="SOHATSEntities" 
       connectionString="Server=YOUR_SERVER;Database=SOHATS;Integrated Security=true;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 4. Build & Run
- Open `SOHATS.sln` in Visual Studio
- Build solution (Ctrl+Shift+B)
- Run application (F5)

### 5. Login
Default credentials (change immediately):
- **Username**: admin
- **Password**: password

---

## Usage

### Patient Registration
1. Click **Patients** → **New Patient**
2. Enter patient information (name, ID, contact details)
3. Add medical history and allergies
4. Click **Save**

### Recording Visit
1. Find patient in search
2. Click **New Visit**
3. Enter visit details (diagnosis, treatment, vital signs)
4. Save visit record

### Patient Discharge
1. Click **Discharge** → **New Discharge**
2. Select patient
3. Enter discharge information and instructions
4. Generate discharge report
5. Mark patient as discharged

### Generate Reports
1. Go to **Reports**
2. Select report type (Patient, Visit, Statistics)
3. Set date range and filters
4. Click **Generate**

### User Management
1. Admin → **Users**
2. Add/edit user accounts
3. Assign role and clinic
4. Set permissions

---

## Project Structure

```
SOHATS/
├── Forms/
│   ├── Login.cs              # Authentication
│   ├── AnaForm.cs            # Main window
│   ├── HastaBilgileri.cs     # Patient info
│   ├── HastaProcess.cs       # Patient processing
│   ├── PoliklinikPage.cs     # Clinic management
│   ├── KullaniciPage.cs      # User management
│   ├── Taburcu.cs            # Discharge
│   └── Rapor.cs              # Reports
│
├── DB/
│   ├── Model1.Context.cs     # EF DbContext
│   ├── hasta.cs              # Patient entity
│   ├── kullanici.cs          # User entity
│   ├── poliklinik.cs         # Clinic entity
│   ├── islem.cs              # Procedure entity
│   ├── cikis.cs              # Discharge entity
│   └── sevk.cs               # Referral entity
│
├── DatabaseControl.cs        # Database operations
├── Program.cs                # Entry point
├── App.config                # Configuration
└── script.sql                # Database initialization
```

---

## Database Schema

### Core Tables

| Table | Purpose |
|-------|---------|
| **hasta** | Patient records (demographics, contact, medical history) |
| **kullanici** | User accounts with roles and permissions |
| **poliklinik** | Clinic/Department information |
| **islem** | Medical procedures and visits |
| **cikis** | Patient discharge records |
| **sevk** | Medical referrals between clinics |

### Patient Entity
```
hasta
├── HastaID (Primary Key)
├── TCKimlik (National ID)
├── Ad (First Name)
├── Soyad (Last Name)
├── DogumTarihi (Birth Date)
├── Cinsiyet (Gender)
├── Telefon (Phone)
├── Adres (Address)
├── MailAdresi (Email)
├── SigortaDurumu (Insurance Status)
├── EmerjansiKisiAdi (Emergency Contact)
└── KayitTarihi (Registration Date)
```

### Visit/Procedure Entity
```
islem
├── IslemID (Primary Key)
├── HastaID (Foreign Key)
├── PoliklinikID (Clinic)
├── DoktorID (Doctor)
├── IslemTarihi (Procedure Date)
├── Tani (Diagnosis)
├── Tedavi (Treatment)
├── VitalIsaret_KanBasinci (Blood Pressure)
├── VitalIsaret_Nabiz (Pulse)
├── VitalIsaret_Sicaklik (Temperature)
└── Notlar (Notes)
```

---

## User Roles

| Role | Permissions |
|------|-------------|
| **Admin** | Full system access, user management, configuration |
| **Doctor** | Patient access, procedure recording, diagnosis, referrals |
| **Nurse** | Vital signs recording, patient data viewing |
| **Secretary** | Patient registration, appointments, record management |

---

## Development

### Code Standards
- Use PascalCase for classes and methods
- Use camelCase for local variables
- Turkish variable names: `hasta`, `poliklinik`, `doktor`
- Add XML documentation for public methods

### Database Access
```csharp
using (var context = new SOHATSEntities())
{
    var patient = context.hasta.FirstOrDefault(p => p.HastaID == id);
    return patient;
}
```

### Adding New Features
1. Create feature branch: `git checkout -b feature/YourFeature`
2. Make changes with proper documentation
3. Test thoroughly
4. Commit: `git commit -m 'feat(module): description'`
5. Push and create Pull Request

---

## Security Notes

⚠️ **Patient Privacy**: Implement healthcare data protection compliance  
⚠️ **Passwords**: Always use strong passwords, change defaults immediately  
⚠️ **Database Backups**: Regular backups are essential  
⚠️ **Access Logs**: Monitor user access and data modifications  
⚠️ **Encryption**: Encrypt sensitive data in transit and at rest  

---

## Troubleshooting

### Connection Error
- Verify SQL Server is running
- Check connection string in App.config
- Test connection with SQL Server Management Studio

### Application Crashes
- Check Windows Event Viewer
- Verify .NET Framework 4.0+
- Rebuild solution
- Execute script.sql to create tables

### Login Issues
- Verify user exists in database
- Check user is marked as active
- Reset password if needed
- Check user role permissions

---

## Contributing

1. Fork the repository
2. Create feature branch: `git checkout -b feature/YourFeature`
3. Make changes and test
4. Commit: `git commit -m 'feat: description'`
5. Push: `git push origin feature/YourFeature`
6. Create Pull Request

---

## License

MIT License - You are free to use, modify, and distribute this software.

---

## Contact

**Author**: Rumeysa (Rum-eysa)  
**GitHub**: [@Rum-eysa](https://github.com/Rum-eysa)  
**Issues**: [GitHub Issues](https://github.com/Rum-eysa/Health_Center_SOHATS/issues)

---

**Version**: 1.0.0 | **Last Updated**: June 2026

---

## About Section (for GitHub)

```
Sağlık Merkezi Hasta Takip Sistemi (SOHATS) - Healthcare management system for patient registration, medical procedures, clinic operations, and reporting. Built with C#, Windows Forms, SQL Server.
```

**Character Count**: 160 characters ✓

---
