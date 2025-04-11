# 📝 Simple Text Editor (WinForms)

This application is a basic **text editor** built with **Windows Forms (C#)**. It provides rich text formatting features like changing fonts, bold/italic/underline styling, and saving/opening files in `.rtf` or `.txt` format.

## ✨ Features

### 🗂 File Management
- **New Document**: Clears the editor and resets font and size to defaults (Tahoma, 14).
- **Open File**: Open `.txt` or `.rtf` files using an Open File Dialog.
- **Save File**: Save the current document as `.rtf`. If the file hasn't been saved before, a Save File Dialog will appear.

### 🎨 Text Formatting
- **Bold**: Applies bold styling to the selected text.
- **Italic**: Applies italic styling to the selected text.
- **Underline**: Applies underline styling to the selected text.
- **Font Selection**: Use the Font ComboBox to select a font (default is Tahoma).
- **Size Selection**: Use the Size ComboBox to select font size (default is 14).

## 🛠 Controls & Tools Used

- **RichTextBox**: Main text area for input and formatting.
- **MenuStrip**: Contains menus like "System" and "Format".
- **ToolStrip**: Provides quick-access buttons with icons for common actions.
- **ComboBox**: Allows users to change font family and size.

## 🚀 Getting Started

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Build and run the application.
4. Start editing, formatting, and saving your text documents!
