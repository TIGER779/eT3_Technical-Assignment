# 📝OPTION-2 Command-Line To-Do App

A simple yet powerful **command-line interface (CLI)** to-do application built with **.NET** and **C#**.  
This tool helps you manage your tasks efficiently right from your terminal, with features like **priorities**, **tags**, and **persistent storage**.

---

## 📌 Features

### **Core Requirements**
- ✅ **Add tasks:** Easily add new tasks to your to-do list.
- ✅ **List tasks:** View all your current tasks with their status and details.
- ✅ **Mark tasks as done:** Mark specific tasks as completed using their index.
- ✅ **Delete tasks:** Permanently remove tasks from your list.
- ✅ **Store tasks in a file:** All tasks are saved in a `tasks.json` file, so your data persists across sessions.

### **Bonus Features**
- ✅ **Creation timestamp:** Each task is automatically stamped with the date and time it was created.
- ✅ **Priority:** Assign a priority level (`low`, `medium`, `high`) to better organize your tasks.
- ✅ **Tags:** Categorize your tasks with custom tags (e.g., `work`, `home`, `project`).

---

## 📂 File Structure
```
Command-Line To-Do App/
├── Commands/
│   ├── AddCommand.cs
│   ├── DeleteCommand.cs
│   ├── DoneCommand.cs
│   ├── HelpCommand.cs
│   └── ListCommand.cs
├── Models/
│   └── TaskItem.cs
├── Services/
│   └── TaskService.cs
├── Storage/
│   └── TaskStorage.cs
├── Program.cs
└── tasks.json
```
---

## 🚀 How to Run Your Program

### **Prerequisites**
- Install the **.NET SDK** (version `6.0` or later).

### **Step-by-Step Guide**

1️⃣ **Clone the repository**  
```bash
git clone https://github.com/YourUsername/Command-Line-To-Do-App.git
```

2️⃣ **Navigate to the project directory**  
```bash
cd Command-Line-To-Do-App
```

3️⃣ **Build the project (compiles and prepares for execution)**   
```bash
dotnet build
```

4️⃣ **Add your first task (high priority, with a "home" tag)**
```bash
dotnet run -- add "Finish project report" --priority high --tag home
```

5️⃣ **Add another task for work**
```bash
dotnet run -- add "Buy milk" --priority medium --tag work
```

6️⃣ **List all tasks (shows index, status, priority, and tags)**
```bash
dotnet run -- list
```

7️⃣ **Filter tasks by priority (only high priority)**
```bash
dotnet run -- list --priority high
```

8️⃣ **Mark the first task as done**    
```bash
dotnet run -- done 1
```

9️⃣ **Delete the second task**    
```bash
dotnet run -- delete 2
```


## 🛠️ Project Details
Language: C#

Framework: .NET

Data Storage: JSON
