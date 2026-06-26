# Health Center Patient Tracking System (SOHATS)

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)
![Platform](https://img.shields.io/badge/platform-Windows-blue)
![Language](https://img.shields.io/badge/language-C%23-239120)
![Healthcare](https://img.shields.io/badge/domain-Healthcare-red)

> **Sağlık Merkezi Hasta Takip Sistemi** | **Health Center Patient Tracking System**

A comprehensive Windows Forms-based application designed to manage patient information, medical operations, and healthcare workflows in health centers. **SOHATS** (Sağlık Ocağı Hasta Takip Sistemi) provides healthcare professionals with an integrated platform to streamline patient management, clinic operations, and medical reporting.

---

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Key Features](#key-features)
- [System Architecture](#system-architecture)
- [Technical Stack](#technical-stack)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation--setup)
- [Usage Guide](#usage-guide)
- [Project Structure](#project-structure)
- [Database Schema](#database-schema)
- [User Roles & Permissions](#user-roles--permissions)
- [Development Guidelines](#development-guidelines)
- [API & Integration](#api--integration)
- [Security Considerations](#security-considerations)
- [Future Roadmap](#future-roadmap)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)
- [License](#license)

---

## Project Overview

**SOHATS** is built to digitize and automate healthcare operations at primary health centers and clinics. The system provides a centralized platform for managing patient records, medical procedures, clinic operations, and generating comprehensive healthcare reports.

### Mission

To enhance healthcare service delivery by providing a reliable, efficient, and secure patient information management system that enables healthcare professionals to deliver better patient care through streamlined workflows and accurate data management.

### Target Users

- Primary Health Centers (Sağlık Ocağı)
- Family Medicine Clinics
- Healthcare Administrators
- Medical Doctors
- Nurses and Medical Staff
- Clinic Secretaries

### Key Objectives

✓ Centralize patient information and medical history  
✓ Streamline clinic operations and patient flows  
✓ Ensure data security and patient confidentiality  
✓ Generate comprehensive medical reports  
✓ Improve operational efficiency  
✓ Support evidence-based decision making  

---

## Key Features

### 👥 Patient Management

- **Patient Registration**: Comprehensive patient profile creation with demographic information
- **Medical History**: Complete patient medical history and past diagnoses
- **Vital Signs Tracking**: Record and monitor patient vital signs (blood pressure, temperature, etc.)
- **Allergies & Medications**: Document patient allergies and current medications
- **Patient Search**: Advanced search and filtering capabilities
- **Visit History**: Track all patient visits and consultations
- **Document Management**: Attach medical documents and test results

### 🏥 Clinic Operations

- **Clinic Management**: Manage multiple clinics/departments (polikliniks)
- **Appointment Scheduling**: Schedule and track patient appointments
- **Clinic Staff Management**: Manage doctors and staff assignments
- **Department Configuration**: Set up and manage clinic departments
- **Resource Management**: Track clinic resources and equipment

### 📋 Medical Procedures & Treatment

- **Procedure Recording**: Document medical procedures performed
- **Treatment Tracking**: Monitor patient treatments and interventions
- **Diagnosis Management**: Record and categorize patient diagnoses
- **Medical Referrals**: Create and track referrals to specialist clinics
- **Hospital Admission/Discharge**: Manage patient admission and discharge processes
- **Patient Transfer**: Track patient transfers between departments

### 🏥 Discharge Management

- **Discharge Processing**: Manage patient discharge procedures
- **Discharge Reports**: Generate comprehensive discharge summaries
- **Follow-up Plans**: Document post-discharge care plans
- **Medication Instructions**: Provide discharge medication instructions

### 📊 Reporting & Analytics

- **Patient Reports**: Generate individual patient reports
- **Clinic Statistics**: Analyze clinic performance metrics
- **Department Reports**: Track department-wise statistics
- **Visit Reports**: Analyze visit patterns and trends
- **Discharge Reports**: Generate discharge statistics
- **Custom Reports**: Create custom reports based on specific criteria

### 🔐 Access Control

- **User Authentication**: Secure login system with role-based access
- **User Roles**: Different permission levels for staff roles
- **Audit Trails**: Track all system activities and changes
- **Data Encryption**: Protect sensitive patient information
- **Activity Logging**: Maintain comprehensive activity logs

---

## System Architecture

### Architectural Pattern

The application implements a **Three-Tier Architecture** pattern:

```
┌─────────────────────────────────────────────────────┐
│       Presentation Layer (UI)                       │
│       Windows Forms Application                    │
│  - Login Form, Main Dashboard, Clinic Forms        │
│  - Patient Forms, Report Forms, Admin Forms        │
└────────────────────┬────────────────────────────────┘
                     │ (Data Binding & Events)
┌────────────────────▼────────────────────────────────┐
│      Business Logic & Data Access Layer             │
│     Entity Framework 6 & Custom Services            │
│  - Database Context, Entity Models                  │
│  - Data Validation, Business Rules                  │
│  - CRUD Operations                                  │
└────────────────────┬────────────────────────────────┘
                     │ (SQL Queries)
┌────────────────────▼────────────────────────────────┐
│      Data Persistence Layer                         │
│      SQL Server Database                            │
│  - Patient Data, Medical Records                    │
│  - User Accounts, Audit Logs                        │
└─────────────────────────────────────────────────────┘
```

### Core Components

**Presentation Layer**
- Login.cs - Authentication interface
- AnaForm.cs - Main application window
- HastaBilgileri.cs - Patient information
- HastaProcess.cs - Patient processing
- PoliklinikPage.cs - Clinic management
- KullaniciPage.cs - User management
- Taburcu.cs - Discharge management
- Rapor.cs - Reporting interface

**Data Access Layer**
- DatabaseControl.cs - Database operations
- Model1.Context.cs - Entity Framework DbContext
- Entity Models (hasta, kullanici, poliklinik, islem, cikis, sevk)

**Database**
- SQL Server (2012+)
- SOHATSDataSet for dataset operations

---

## Technical Stack

| Component | Technology | Version | Purpose |
|-----------|-----------|---------|---------|
| **Language** | C# | .NET Framework 4.x | Application development |
| **UI Framework** | Windows Forms | .NET Framework | User interface |
| **ORM** | Entity Framework | 6.0+ | Database access |
| **Database** | SQL Server | 2012+ | Data persistence |
| **Architecture** | Three-Tier | — | Application structure |
| **Dataset** | ADO.NET Dataset | — | Data binding |
| **IDE** | Visual Studio | 2015+ | Development |

---

## Prerequisites

### System Requirements

- **Operating System**: Windows 7 Service Pack 1 or later (Windows 10/11 recommended)
- **RAM**: 4 GB minimum (8 GB recommended)
- **Storage**: 2 GB for application and data
- **.NET Framework**: 4.0 or higher
- **SQL Server**: 2012 or later (Express Edition acceptable)

### Software Requirements

- Visual Studio 2015 or later
- SQL Server Express (or full SQL Server)
- SQL Server Management Studio
- .NET Framework 4.0 Developer Pack

### Network Requirements

- Local network connectivity for database server
- TCP port 1433 (SQL Server default) must be accessible
- Sufficient permissions for database creation

---

## Installation & Setup

### Step 1: Install Prerequisites

#### Install SQL Server

1. Download SQL Server 2016+ or SQL Server Express
2. Run the installer and follow setup wizard
3. Choose Mixed Mode authentication (SQL + Windows)
4. Note down the server name and port (default: localhost\SQLEXPRESS)

#### Install SQL Server Management Studio

1. Download SQL Server Management Studio
2. Install and connect to your SQL Server instance

### Step 2: Clone the Repository

```bash
git clone https://github.com/Rum-eysa/Health_Center_SOHATS.git
cd Health_Center_SOHATS/Saglik_Ocagi_Hasta_Takip_Sistemi
```

### Step 3: Database Setup

#### Create Database

1. Open SQL Server Management Studio
2. Connect to your SQL Server instance
3. Execute the provided database script:

```sql
-- Open and execute script.sql file in SQL Server Management Studio
-- This creates all necessary tables and initial data
```

Alternatively, create database manually:

```sql
CREATE DATABASE SOHATS;
USE SOHATS;
-- Then execute script.sql
```

### Step 4: Update Connection String

1. Open the Visual Studio project
2. Locate `App.config` file
3. Update the connection string:

```xml
<configuration>
  <connectionStrings>
    <add name="SOHATSEntities" 
         connectionString="Server=YOUR_SERVER;Database=SOHATS;Integrated Security=true;" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

Replace `YOUR_SERVER` with your SQL Server instance name (e.g., `.\SQLEXPRESS` or `COMPUTERNAME\SQLSERVER2019`)

### Step 5: Build the Solution

1. Open `SOHATS.sln` in Visual Studio
2. Restore NuGet packages:
   - Right-click solution → Restore NuGet Packages
3. Build the solution:
   - Build → Build Solution (Ctrl+Shift+B)
4. Resolve any dependency issues

### Step 6: Run the Application

1. Set SOHATS project as startup project
2. Press F5 or click Start button
3. Application launches with login screen

### Step 7: Initial Login

Use default credentials (change immediately):

```
Username: admin
Password: password
```

---

## Usage Guide

### Starting the Application

1. Launch SOHATS.exe or start from Visual Studio
2. Login screen appears
3. Enter credentials and click login
4. Main dashboard displays

### User Dashboard

The main window provides access to all functions:

- **Patient Menu**: Patient registration, search, and management
- **Clinic Menu**: Clinic operations and department management
- **Procedures Menu**: Record medical procedures and treatments
- **Discharge Menu**: Manage patient discharges
- **Reports Menu**: Generate various reports
- **Admin Menu**: User management and system configuration

### Patient Registration

1. Click **Patients** → **New Patient**
2. Enter patient information:
   - Personal details (Name, Age, ID)
   - Contact information
   - Medical history
   - Allergies and medications
3. Click **Save**
4. Patient receives unique ID

### Recording Patient Visit

1. Click **Patients** → **Find Patient**
2. Search and select patient
3. Click **New Visit**
4. Record visit details:
   - Visit date and time
   - Clinic/Department
   - Doctor name
   - Reason for visit
   - Vital signs
   - Diagnosis
   - Treatment plan
5. Click **Save Visit**

### Recording Medical Procedures

1. Open patient record
2. Click **Procedures**
3. Add new procedure:
   - Procedure type
   - Date and time
   - Performing doctor
   - Procedure details
   - Results/findings
4. Save procedure record

### Patient Discharge

1. Click **Discharge** → **New Discharge**
2. Select patient
3. Fill discharge information:
   - Discharge date
   - Final diagnosis
   - Treatments provided
   - Discharge instructions
   - Follow-up appointments
4. Generate discharge report
5. Save and mark patient as discharged

### Generating Reports

1. Click **Reports**
2. Select report type:
   - Patient Report
   - Visit Report
   - Department Statistics
   - Discharge Summary
   - Clinic Performance
3. Set date range and filters
4. Click **Generate**
5. View or export report (PDF/Excel if available)

### Clinic Management

1. Go to **Admin** → **Clinics**
2. View existing clinics
3. Add new clinic:
   - Clinic name
   - Location
   - Department
   - Assigned staff
4. Configure clinic settings
5. Save configuration

### User Management

1. Navigate to **Admin** → **Users**
2. View all system users
3. Add new user:
   - Username
   - Password (set strong password)
   - Role (Doctor, Nurse, Secretary, Admin)
   - Assigned clinic
4. Assign permissions based on role
5. Save user account

---

## Project Structure

```
Health_Center_SOHATS/
│
├── Saglik_Ocagi_Hasta_Takip_Sistemi/
│   │
│   ├── SOHATS.sln                      # Visual Studio Solution
│   │
│   ├── SOHATS/                         # Main Application Project
│   │   │
│   │   ├── Forms/                      # Windows Forms
│   │   │   ├── Login.cs                # Login authentication
│   │   │   ├── AnaForm.cs              # Main application window
│   │   │   ├── HastaBilgileri.cs       # Patient information form
│   │   │   ├── HastaProcess.cs         # Patient processing form
│   │   │   ├── PoliklinikPage.cs       # Clinic management
│   │   │   ├── KullaniciPage.cs        # User management
│   │   │   ├── Taburcu.cs              # Discharge management
│   │   │   ├── Rapor.cs                # Report generation
│   │   │   ├── DosyaBul.cs             # File browser utility
│   │   │   └── [*.Designer.cs]         # Form designers
│   │   │
│   │   ├── DB/                         # Entity Framework Models
│   │   │   ├── Model1.cs               # EF Model definition
│   │   │   ├── Model1.Context.cs       # DbContext
│   │   │   ├── Model1.Designer.cs      # Model designer
│   │   │   ├── hasta.cs                # Patient entity
│   │   │   ├── kullanici.cs            # User entity
│   │   │   ├── poliklinik.cs           # Clinic entity
│   │   │   ├── islem.cs                # Procedure entity
│   │   │   ├── cikis.cs                # Exit/Discharge entity
│   │   │   └── sevk.cs                 # Referral entity
│   │   │
│   │   ├── DatabaseControl.cs          # Database operations
│   │   ├── FormControl.cs              # Form utilities
│   │   ├── SOHATSDataSet.cs            # ADO.NET Dataset
│   │   ├── Program.cs                  # Application entry point
│   │   ├── App.config                  # Configuration file
│   │   │
│   │   ├── Properties/
│   │   │   ├── AssemblyInfo.cs
│   │   │   ├── Resources.resx
│   │   │   └── Settings.settings
│   │   │
│   │   ├── [*.resx]                    # Resource files (UI resources)
│   │   └── packages.config             # NuGet packages
│   │
│   ├── script.sql                      # Database initialization script
│   └── saglik-bakanligi-logo.ico       # Application icon
│
├── .gitignore                          # Git ignore rules
├── README.md                           # This file
└── LICENSE                             # Project license
```

---

## Database Schema

### Core Entities

#### Hasta (Patient)
```
Hasta
├── HastaID (PK)
├── TCKimlik (National ID)
├── Ad (First Name)
├── Soyad (Last Name)
├── DogumTarihi (Date of Birth)
├── Cinsiyet (Gender)
├── Telefon (Phone)
├── Adres (Address)
├── MailAdresi (Email)
├── CalismaYeri (Work Place)
├── SigortaDurumu (Insurance Status)
├── EmerjansiKisiAdi (Emergency Contact Name)
├── EmerjansiKisiTelefon (Emergency Contact Phone)
├── KayitTarihi (Registration Date)
├── GuncellemeTarihi (Update Date)
└── AktifMi (Is Active)
```

#### Kullanici (User)
```
Kullanici
├── KullaniciID (PK)
├── KullaniciAdi (Username)
├── Sifre (Password - Encrypted)
├── Ad (First Name)
├── Soyad (Last Name)
├── Rol (Role: Admin, Doctor, Nurse, Secretary)
├── PoliklinikID (Assigned Clinic)
├── Telefon (Phone)
├── MailAdresi (Email)
├── AktifMi (Is Active)
├── SonGirisZamani (Last Login Time)
├── KayitTarihi (Registration Date)
└── GuncellemeTarihi (Update Date)
```

#### Poliklinik (Clinic/Department)
```
Poliklinik
├── PoliklinikID (PK)
├── Ad (Department Name)
├── Kat (Floor)
├── Konum (Location)
├── Kapasite (Capacity)
├── CalismaBaslamaZamani (Start Time)
├── CalismaKapanmaZamani (End Time)
├── SorumluKimse (Responsible Person)
├── AktifMi (Is Active)
├── KayitTarihi (Registration Date)
└── GuncellemeTarihi (Update Date)
```

#### Islem (Procedure/Visit)
```
Islem
├── IslemID (PK)
├── HastaID (FK - Patient)
├── PoliklinikID (FK - Clinic)
├── DoktorID (FK - Doctor/User)
├── IslemTarihi (Procedure Date)
├── Saati (Time)
├── Tani (Diagnosis)
├── Tedavi (Treatment)
├── Notlar (Notes)
├── VitalIsaret_KanBasinci (Blood Pressure)
├── VitalIsaret_Nabiz (Pulse)
├── VitalIsaret_Sicaklik (Temperature)
├── VitalIsaret_SoluNumuOzurluPuanı (Respiratory Rate)
├── KayitTarihi (Registration Date)
└── GuncellemeTarihi (Update Date)
```

#### Cikis (Discharge)
```
Cikis
├── CikisID (PK)
├── HastaID (FK - Patient)
├── IslemID (FK - Related Procedure)
├── CikisTarihi (Discharge Date)
├── CikisSonuTani (Final Diagnosis)
├── CikisSonuMuamele (Treatment Summary)
├── TakipTalimatlar (Follow-up Instructions)
├── Notlar (Notes)
├── KayitTarihi (Registration Date)
└── GuncellemeTarihi (Update Date)
```

#### Sevk (Referral)
```
Sevk
├── SevkID (PK)
├── HastaID (FK - Patient)
├── GodericiPoliklinikID (FK - Referring Clinic)
├── AlanPoliklinikID (FK - Receiving Clinic)
├── SevkTarihi (Referral Date)
├── Neden (Reason)
├── Durumu (Status: Pending, Accepted, Completed)
├── Notlar (Notes)
├── KayitTarihi (Registration Date)
└── GuncellemeTarihi (Update Date)
```

---

## User Roles & Permissions

### Administrator (Yönetici)
- **Permissions**: Full system access
- **Responsibilities**:
  - User account management
  - System configuration
  - Database maintenance
  - Audit trail review
  - Clinic/department setup

### Doctor (Doktor)
- **Permissions**: Patient data access, procedure recording
- **Responsibilities**:
  - Patient diagnosis
  - Treatment planning
  - Procedure documentation
  - Referral creation
  - Report generation

### Nurse (Hemşire)
- **Permissions**: Patient data viewing, vital signs recording
- **Responsibilities**:
  - Vital signs measurement
  - Patient care assistance
  - Medical supplies tracking
  - Appointment assistance

### Secretary (Sekreter)
- **Permissions**: Patient registration, appointment scheduling
- **Responsibilities**:
  - New patient registration
  - Appointment scheduling
  - Patient information updates
  - Record filing
  - Phone communication

---

## Development Guidelines

### Code Conventions

**Naming Conventions**:
- Classes: PascalCase (e.g., `PatientForm`, `DatabaseControl`)
- Methods: PascalCase (e.g., `GetPatient()`, `SaveRecord()`)
- Properties: PascalCase (e.g., `PatientName`)
- Fields: camelCase with underscore prefix (e.g., `_patientId`)
- Local variables: camelCase (e.g., `patientName`)

**Turkish Language Usage**:
- Class names: English (e.g., PatientForm)
- Variable names: Turkish (e.g., `hasta`, `poliklinik`, `doktor`)
- Database: Turkish table/column names
- UI: Turkish language for user-facing text

### Entity Framework Best Practices

```csharp
// Correct: Using DbContext with using statement
using (var context = new SOHATSEntities())
{
    var patient = context.hasta.FirstOrDefault(p => p.HastaID == id);
    if (patient != null)
    {
        patient.Ad = "New Name";
        context.SaveChanges();
    }
}

// Correct: LINQ query pattern
var patients = context.hasta
    .Where(p => p.AktifMi == true)
    .OrderBy(p => p.Ad)
    .ToList();
```

### Data Validation

```csharp
// Implement validation in entity models
public class hasta
{
    public int HastaID { get; set; }
    
    [Required(ErrorMessage = "Hasta adı gereklidir")]
    [StringLength(50, MinimumLength = 2)]
    public string Ad { get; set; }
    
    [Required]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "Geçerli TC Kimlik numarası girin")]
    public string TCKimlik { get; set; }
    
    [EmailAddress]
    public string MailAdresi { get; set; }
}
```

### Security Considerations

```csharp
// Correct: Password hashing
public class AuthenticationService
{
    public bool VerifyPassword(string password, string hash)
    {
        // Use proper hashing algorithm (bcrypt, PBKDF2, etc.)
        return BCrypt.Net.BCrypt.Verify(password, hash);
    }
    
    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}

// Correct: Parameterized queries to prevent SQL injection
using (var context = new SOHATSEntities())
{
    var patient = context.hasta
        .SqlQuery("SELECT * FROM hasta WHERE HastaID = @id", 
                  new SqlParameter("@id", patientId))
        .FirstOrDefault();
}
```

### Branching Strategy

- `main` - Production-ready code
- `develop` - Development branch
- `feature/*` - Feature development
- `bugfix/*` - Bug fixes
- `hotfix/*` - Critical production fixes

### Commit Message Format

```
type(scope): subject

body

footer
```

Examples:
- `feat(patient): add patient search by TC number`
- `fix(discharge): resolve discharge date validation error`
- `docs(readme): update installation instructions`

---

## API & Integration

### Database Connection String

The application uses Entity Framework 6 with SQL Server:

```csharp
// Model1.Context.cs
public partial class SOHATSEntities : DbContext
{
    public SOHATSEntities()
        : base("name=SOHATSEntities")
    {
    }

    public virtual DbSet<hasta> hasta { get; set; }
    public virtual DbSet<kullanici> kullanici { get; set; }
    public virtual DbSet<poliklinik> poliklinik { get; set; }
    public virtual DbSet<islem> islem { get; set; }
    public virtual DbSet<cikis> cikis { get; set; }
    public virtual DbSet<sevk> sevk { get; set; }
}
```

### Common Operations

#### Get Patient
```csharp
using (var context = new SOHATSEntities())
{
    var patient = context.hasta.FirstOrDefault(p => p.HastaID == patientId);
    return patient;
}
```

#### Create New Visit
```csharp
using (var context = new SOHATSEntities())
{
    var visit = new islem
    {
        HastaID = patientId,
        PoliklinikID = clinicId,
        DoktorID = doctorId,
        IslemTarihi = DateTime.Now,
        Tani = diagnosis,
        Tedavi = treatment,
        KayitTarihi = DateTime.Now
    };
    context.islem.Add(visit);
    context.SaveChanges();
}
```

#### Update Patient Record
```csharp
using (var context = new SOHATSEntities())
{
    var patient = context.hasta.Find(patientId);
    if (patient != null)
    {
        patient.Ad = newName;
        patient.GuncellemeTarihi = DateTime.Now;
        context.SaveChanges();
    }
}
```

---

## Security Considerations

### Data Protection

✓ **Patient Confidentiality**: Comply with healthcare privacy regulations  
✓ **Access Control**: Role-based access to patient data  
✓ **Audit Logging**: Track all data access and modifications  
✓ **Data Encryption**: Encrypt sensitive data (passwords, SSNs)  
✓ **Backup Strategy**: Regular database backups  

### Authentication & Authorization

- Implement strong password policies
- Use encrypted password storage (bcrypt, PBKDF2)
- Session timeout after inactivity
- Log all login attempts
- Implement account lockout after failed attempts

### Database Security

- Use integrated or mixed-mode SQL authentication
- Create separate database users with minimal permissions
- Regular security updates and patches
- Backup encryption
- Regular integrity checks

---

## Future Roadmap

### Version 2.0

- [ ] **Web-based Interface**: ASP.NET Core web application
- [ ] **Mobile App**: Patient access and appointment booking
- [ ] **Telemedicine Integration**: Remote consultation capabilities
- [ ] **Advanced Analytics**: Predictive analytics and health trends
- [ ] **Email/SMS Notifications**: Automated patient notifications
- [ ] **Lab Integration**: Integration with laboratory systems
- [ ] **Pharmacy Integration**: Prescription management system
- [ ] **Appointment Reminders**: Automated SMS/email reminders

### Version 2.5+

- [ ] **AI-Powered Diagnosis Support**: ML-based diagnostic assistance
- [ ] **Cloud Backup**: Automatic cloud synchronization
- [ ] **Multi-clinic Management**: Support for multiple clinic chains
- [ ] **Multilingual Support**: Support for multiple languages
- [ ] **Hospital Integration**: Connect with hospital systems
- [ ] **Health Records Exchange**: EHR/HIE integration
- [ ] **Video Consultation**: Built-in video conferencing
- [ ] **Payment Gateway**: Online payment processing
- [ ] **Compliance Reporting**: Automated healthcare compliance reports

---

## Troubleshooting

### Database Connection Issues

**Problem**: "Cannot connect to database server"

**Solutions**:
1. Verify SQL Server is running:
   ```bash
   # Check SQL Server status in Services
   services.msc
   ```
2. Verify connection string in App.config
3. Check firewall allows port 1433
4. Test connection with SQL Management Studio
5. Verify user has database access permissions

### Application Startup Issues

**Problem**: "Application crashes on startup"

**Solutions**:
1. Check Windows Event Viewer for errors
2. Verify .NET Framework version (4.0+)
3. Clear Visual Studio cache
4. Rebuild solution
5. Check App.config validity

### Database Schema Issues

**Problem**: "Table 'hasta' does not exist"

**Solutions**:
1. Execute script.sql to create all tables
2. Verify database was created correctly
3. Check connection is to correct database
4. Run database integrity check

### Login Issues

**Problem**: "Login fails with correct credentials"

**Solutions**:
1. Verify user exists in database
2. Check user is marked as active
3. Reset password for user account
4. Check user role permissions
5. Clear application cache

### Performance Issues

**Problem**: "Application runs slowly with many records"

**Solutions**:
1. Add database indexes on frequently searched columns
2. Implement pagination for large result sets
3. Use asynchronous operations
4. Optimize queries and LINQ expressions
5. Archive old data to separate database

---

## Contributing

We welcome contributions to improve this healthcare management system.

### Contribution Process

1. **Fork** the repository
2. **Create** a feature branch: `git checkout -b feature/YourFeature`
3. **Develop** your feature with proper documentation
4. **Test** thoroughly (unit tests, integration tests)
5. **Commit**: `git commit -m 'feat(module): add feature description'`
6. **Push**: `git push origin feature/YourFeature`
7. **Create** a Pull Request with detailed description

### Contribution Guidelines

- Follow project code conventions
- Write clean, well-documented code
- Add XML documentation for public methods
- Include unit tests for new functionality
- Update README for significant changes
- Ensure code passes security review

### Code Review Process

1. Automated tests must pass
2. Code review by at least one maintainer
3. Address requested changes
4. Approval and merge to develop branch

---

## License

This project is licensed under the **MIT License** - see LICENSE file for complete details.

The software is provided "AS IS" without warranty. You are free to use, modify, and distribute this software subject to the conditions in the MIT License.

---

## Contact & Support

### Author

**Rumeysa (Rum-eysa)**  
GitHub: [@Rum-eysa](https://github.com/Rum-eysa)

### Getting Help

- **Issues**: Report bugs on [GitHub Issues](https://github.com/Rum-eysa/Health_Center_SOHATS/issues)
- **Questions**: Use GitHub Discussions
- **Security Issues**: Report privately to maintainer

### Community

- Star the repository if you find it useful
- Share feedback and suggestions
- Follow for updates and announcements

---

## Acknowledgments

- Healthcare professionals who provided requirements
- Open-source libraries used in this project
- Contributors and testers
- .NET and Entity Framework community

---

## Version History

### v1.0.0 (Current)
- Patient management system
- Clinic operations management
- Medical procedure tracking
- Discharge management
- Report generation
- User authentication and role-based access
- Windows Forms interface
- SQL Server database

---

## Healthcare Compliance

This system is designed to support healthcare operations. When implementing in a healthcare setting, ensure compliance with:

- **HIPAA** (Health Insurance Portability and Accountability Act) - for US implementations
- **GDPR** (General Data Protection Regulation) - for EU implementations
- **Turkish Health Data Protection** - for Turkish implementations
- Local and national healthcare regulations
- Medical records retention policies
- Patient privacy and confidentiality requirements

---

## Important Notes

⚠️ **Data Backup**: Regular backups are essential. Implement automated backup procedures.

⚠️ **Patient Privacy**: Ensure all patient data is handled according to healthcare regulations.

⚠️ **Access Control**: Implement proper authentication and authorization.

⚠️ **Audit Trails**: Maintain comprehensive logs of all system activities.

---

**Last Updated**: June 2026  
**Maintainer**: Rum-eysa  
**Repository**: [Health_Center_SOHATS](https://github.com/Rum-eysa/Health_Center_SOHATS)

---

### Quick Links

- [Installation Guide](#installation--setup)
- [Usage Guide](#usage-guide)
- [Database Schema](#database-schema)
- [Project Structure](#project-structure)
- [Contributing Guide](#contributing)
- [Report a Bug](https://github.com/Rum-eysa/Health_Center_SOHATS/issues/new?template=bug_report.md)
- [Request a Feature](https://github.com/Rum-eysa/Health_Center_SOHATS/issues/new?template=feature_request.md)
