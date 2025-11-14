# Flappy Bird Clone (Unity 6000)

## 🎮 Overview

This is a Flappy Bird–style 2D game built in **Unity 6000 (Unity 6)**.
Players control a bird that must navigate through a series of pipes. The goal is to survive as long as possible while collecting points by passing through pipe gaps.

---

## 🛠 Features

* **Score System:** Increases when the bird passes through pipes.
* **Game Over Screen:** Appears when the bird hits a pipe or the ground.
* **Restart Functionality:** Restart the game directly from the UI.
* **Context Menu for Testing:** Increase score in the editor using Unity's `[ContextMenu]`.
* **2D Physics:** Uses Rigidbody2D and Collider2D for realistic movement and collisions.
* **Player Layer & Tag Support:** Uses layers or tags for collision detection with pipes.

---

## 📂 Project Structure

```
Assets/
├─ Scripts/
│  ├─ LogicScript.cs       # Handles scoring, game over, and restart
│  └─ PipeMiddleScript.cs  # Detects player passing through pipes
├─ Prefabs/
│  ├─ Player.prefab        # Bird character
│  └─ Pipe.prefab          # Pipe obstacle
├─ Scenes/
│  └─ MainScene.unity
└─ UI/
   ├─ ScoreText
   └─ GameOverScreen
```

---

## ⚡ How to Play

1. **Start the Game:** Press Play in Unity or build & run the game.
2. **Control the Bird:** Tap/click to make the bird flap and gain height.
3. **Score Points:** Pass through pipe gaps to increase your score.
4. **Game Over:** Hitting a pipe or the ground triggers the Game Over screen.
5. **Restart:** Click the restart button to play again.

---

## 🛠 Installation

1. Clone or download this repository.
2. Open Unity 6000 and load the project folder.
3. Open `MainScene.unity` in the **Scenes** folder.
4. Press **Play** to test the game in the editor.

---

## ⚙️ Important Notes

* **Colliders:** Make sure `PipeMiddle` has a **BoxCollider2D** set as `Is Trigger`.
* **Player Rigidbody:** Player must have a **Rigidbody2D** for trigger detection.
* **Layers/Tags:** Pipes check for the player using **layer = 3** or **tag = "Player"**.
* **Z-Position:** Keep both Player and Pipes on the same Z-plane (default `z = 0`) for collisions.

---

## ✨ Future Improvements

* Add **sound effects** for flaps and scoring.
* Implement **animated bird sprites**.
* Add **increasing difficulty** as the score rises.
* Add **mobile input support** for touch controls.
* Save **high score** locally or online.

---

## 📌 Contact

Developed by [Your Name]
Email: `moessam941@gmail.com`
