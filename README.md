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

- [Visual Studio 2022+](https://visualstudio.microsoft.com/) with `.NET desktop development` workload
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

---

### 🛠️ Setup

1. **Clone the repo**
   ```bash
   git clone https://github.com/your-username/control-your-copy.git
   cd control-your-copy
