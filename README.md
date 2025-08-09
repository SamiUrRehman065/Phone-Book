# 📞 Phone Book Management System

A modular, data-structure-driven desktop application built in C# using Windows Forms and SQL Server. Designed as a final semester DSA project, this system demonstrates mastery of core data structures—Trie, Hash Table, Linked List—while delivering a real-world contact management experience.

---

## 🧭 Introduction & Overview

This Phone Book Management System is more than just a contact manager—it's a showcase of algorithmic thinking, modular architecture, and practical software engineering. Built from scratch using custom data structures and integrated with SQL Server, it reflects the journey of a developer who turned theory into application.

---

## 👨‍💻 Developer

**Sami Ur Rehman**  
Final Year Computer Science Student  
Karachi, Pakistan  

> “I didn’t just want to pass the course—I wanted to prove to myself that I could build something real, structured, and scalable. This project is my reflection of growth.”  
> — *Sami Ur Rehman*

---

## 📦 Modules

### 🔧 Core Modules
- **Contact.cs**: Defines the data model for each contact.
- **TrieTree.cs**: Enables efficient name-based search and alphabetical sorting.
- **HashTable.cs**: Provides fast phone-based lookup with collision handling.
- **CustomLinkedList.cs / Node.cs**: Implements linked list logic for hash collisions and UI display.
- **SQLDataManager.cs**: Handles database operations (CRUD) with SQL Server.

### 🖥️ UI Modules
- **Form1.cs**: Main interface for viewing, searching, and filtering contacts.
- **AddContactForm.cs**: Form for adding new contacts.
- **DeleteContactForm.cs**: Form for deleting contacts.

### 🚀 Entry Point
- **Program.cs**: Initializes the application and launches the main form.

---


## 📁 Folder Structure

```
Phone Book/
│
├── AddContactForm.cs
├── Contact.cs
├── CustomLinkedList.cs
├── DeleteContactForm.cs
├── Form1.cs
├── HashTable.cs
├── Node.cs
├── Program.cs
├── SQLDataManager.cs
└── TrieTree.cs
```

---

## 🛠️ Tech Stack

- **Language**: C# (.NET Framework)
- **UI**: Windows Forms
- **Database**: SQL Server (LocalDB)
- **Data Structures**: Trie, Hash Table, Linked List
- **IDE**: Visual Studio

---

## ✨ Features

- Add, delete, and search contacts by phone number
- Trie-based alphabetical sorting by name
- Hash table for fast lookup and collision resolution
- SQL-backed persistence for long-term storage
- Category-based filtering (Family, Friends, Business)
- Modular UI with responsive feedback
- Clean separation of logic and presentation

---

## 🧱 Architectural Milestones

- ✅ Designed and implemented a custom Trie for name-based retrieval
- ✅ Built a hash table with collision resolution using linked lists
- ✅ Integrated SQL Server for persistent storage
- ✅ Developed modular forms for add/delete workflows
- ✅ Created a unified UI that reflects both in-memory and persistent data
- ✅ Documented every module with clarity and purpose

---

## 🚀 Usage

1. Clone the repository
2. Open the solution in Visual Studio
3. Ensure SQL Server is running and the `PhoneBookDataBase` is created
4. Run the application
5. Use the UI to add, delete, search, and filter contacts

---

## 📦 Deployment Guidelines

- Requires .NET Framework and SQL Server Express
- Connection string is hardcoded in `SQLDataManager.cs` — update if needed
- Database schema:
  ```sql
  CREATE TABLE Contacts (
      Name NVARCHAR(100),
      Phone NVARCHAR(20),
      Email NVARCHAR(100),
      Category NVARCHAR(50),
      PhoneHash INT PRIMARY KEY
  );
  ```

---

## 👤 Author

**Sami Ur Rehman**  
📧 samiurrehman065@gmail.com  
💼 [GitHub Profile](https://github.com/SamiUrRehman065)

---

## 💬 Developer Reflection

> “This project taught me how to turn abstract data structures into real-world solutions. Every bug, every refactor, every design choice was a step forward—not just in code, but in confidence.”  
> — *Sami Ur Rehman*

---

## 🤝 Message to Contributors

If you’re a fellow student, developer, or educator who wants to build on this project, I welcome you.

> “Code is not just what we write—it’s what we leave behind for others to build upon.”  
> — *Sami Ur Rehman*

Feel free to fork, improve, or reach out. Let’s keep learning together.
