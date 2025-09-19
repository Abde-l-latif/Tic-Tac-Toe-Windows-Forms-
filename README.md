Tic-Tac-Toe (Windows Forms)

A simple Tic-Tac-Toe (X-O) game built with C# and Windows Forms.
This project was created to practice Windows Forms UI programming, event handling, and game logic structuring in C#.

🎮 Features

Two-player mode (Player 1 vs Player 2).

Visual board built using PictureBoxes with X and O images.

Tracks the current player.

Detects and highlights the winning combination.

Declares a winner or draw.

Restart button to reset the game.

Uses struct and enum to manage game state cleanly.

🛠️ Technologies Used

C# .NET (Windows Forms)

GDI+ drawing for board grid lines

PictureBox controls for the game cells

Resources (images for X, O, and empty cell)

📂 Project Structure
tic_tac_toe/
│── Form1.cs           # Main game logic
│── Form1.Designer.cs  # Windows Forms designer file
│── Form1.resx         # Resources (images, labels, etc.)
│── Program.cs         # Entry point
│── Properties/
│   ├── Resources.resx # X, O, and question mark images
│   ├── Settings.settings
│── bin/               # Compiled executables
│── obj/               # Temporary build files

🚀 How to Run

Clone the repository:

git clone https://github.com/your-username/tic-tac-toe-winforms.git


Open the project in Visual Studio.

Make sure you have .NET Framework (4.x or later) installed.

Press F5 or click Start Debugging to run the game.

📸 Screenshots

(Add screenshots here if you have any — e.g., game start, player moves, winner screen)

📖 Learning Goals

Practice with Windows Forms events (Click, Paint, Load).

Using enums and structs to model game state.

Separating game logic from UI controls.

Resource management with Properties.Resources.

🧩 Future Improvements

Add AI opponent (single-player mode).

Add score tracking across multiple games.

Replace PictureBoxes with a custom drawn board for performance scalability.

Improve UI with animations and sounds.
