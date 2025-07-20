# 🧠 Control-your-Copy

> _"Is your 'C' key giving up on you? Fear not, this tool has got your back (and clipboard)."_

This repo is dedicated to all the folks with **weak Ctrl + C keys** out there 💀.

I was personally tired of switching tabs, hitting Ctrl + V, and being met with **absolutely nothing**. Turns out, what I thought was copied… was **never copied**.

So I built this little tool to scream (gently) near your cursor:
> “Yes, buddy, it’s copied. You’re good to go.” ✅

---

## ✨ Features

- 📋 Detects when you copy (Ctrl + C)
- 💬 Displays a floating popup with the copied content
- 🐭 Appears exactly where your cursor is
- ⏳ Disappears automatically after 1 second
- 🔇 Runs silently in the background
- 💡 Built with .NET 8 and `Gma.System.MouseKeyHook`

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

---

### 🛠️ Setup

1. **Clone the repo**
   ```bash
   git clone https://github.com/Yugma2605/Control-your-Copy.git
   cd control-your-copy

2. **Restore packages**
   ```bash
   dotnet restore

3. **Build**
   ```bash
   dotnet build

4. **Run it**
   ```bash
   dotnet run --project Control-your-Copy

