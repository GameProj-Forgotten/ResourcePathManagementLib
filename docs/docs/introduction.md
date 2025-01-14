# Introduction
ResourcePathManagementLib is a library that focuses on efficiently storing and accessing the paths of streaming assets throughout the Forgotten project.

The main resource paths handled by ResourcePathManagementLib are as follows:
- Map generation

<br>

Please note that this library is built based on .Net Framework 4.8.

<br><br>
<div align="center">
  <img src="https://github.com/user-attachments/assets/9f2e8c0d-7701-4050-ae0e-4d59992ec7b6" width="20%">
</div>
<br><br>

The representative functions provided by this library are as follows:
```
ResourcePathManagementLib
└── Resource Path Management
    ├── sealed class ChiefResourcePathManager : SingleTon<ChiefResourcePathManager>, IDisposable
    └── static class MapGenResourcePathInterface
```