using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace GraphicsLearn.Task_5
{
    public partial class Task5 : Form
    {
        private Graphics graphics;
        private readonly Bitmap bitmap;
        private Point positionPlayer;
        private CurrentAnimation currentAnimation = CurrentAnimation.None;
        private Image character;

        private readonly Image Background = Image.FromFile(@"C:\\Users\\Yrulewet\\source\\repos\\LearcnCS\\GraphicsLearn\\GraphicsLearn\\Task_5\\Background\\BackgroundJapane.jpg");

        private int currentAnimationIndex = 1;
        private int currentJumpAnimationIndex = 1;
        private int currentAttackAnimationIndex = 1;

        private CurrentAnimation LastPressed = CurrentAnimation.Right;

        enum CurrentAnimation
        {
            Up = 0,
            Down,
            Left,
            Right,
            None,
            Space,
            Attack
        }

        public Task5()
        {
            InitializeComponent();
            
            this.positionPlayer = new Point(this.Scene.Width/ 2 - 125, this.Scene.Height - 165);

            this.bitmap = new Bitmap(this.Scene.Width, this.Scene.Height);
            
            this.graphics = Graphics.FromImage(bitmap);
            this.graphics.SmoothingMode = this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            this.character = Image.FromFile($@"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_5\Sprite\Walk\RightWalk1.png");

            this.KeyDown += new KeyEventHandler(this.Keyboard);
            this.KeyUp += new KeyEventHandler(this.StateFull);

            this.DoubleBuffered = true;

            this.JumpTimer.Interval = 60;
            this.JumpTimer.Tick += new EventHandler(CheckJump);

            this.timer.Interval = 40;
            this.timer.Tick += new EventHandler(CheckUpdate);
            this.timer.Start();

            
            this.AttackTimer.Interval = 60;
            this.AttackTimer.Tick += new EventHandler(CheckAttack);
            

        }

        private void CheckAttack(object sender, EventArgs e)
        {
            SetBackGround();
            
            if (currentAttackAnimationIndex == 7)
            {
                currentAttackAnimationIndex = 7;
                timer.Start();
                this.AttackTimer.Stop();
                return;
            }

            AttackCharacter();

            currentAttackAnimationIndex++;
            
            this.Scene.Image = bitmap;
        }


        private void CheckJump(object sender, EventArgs e)
        {
            SetBackGround();

            if (currentJumpAnimationIndex == 11)
            {
                currentJumpAnimationIndex = 11;
                timer.Start();
                JumpTimer.Stop();
                return;
            }

            if (currentJumpAnimationIndex > 2 && currentJumpAnimationIndex < 5) this.positionPlayer.Y -= 20;
            if (currentJumpAnimationIndex > 5 && currentJumpAnimationIndex != 10) this.positionPlayer.Y += 10;

            JumpCharacter();

            currentJumpAnimationIndex++;

            this.Scene.Image = bitmap;
        }

        private void JumpCharacter()
        {
            character = Image.FromFile($@"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_5\Sprite\Jump\Jump{currentJumpAnimationIndex}.png");

            if (LastPressed == CurrentAnimation.Left) character.RotateFlip(RotateFlipType.Rotate180FlipY);
            
            this.graphics.DrawImage(character, this.positionPlayer.X, this.positionPlayer.Y);
        }

        private void AttackCharacter()
        {
            character = Image.FromFile($@"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_5\Sprite\Attack\Attack{currentAttackAnimationIndex}.png");

            if (LastPressed == CurrentAnimation.Left) character.RotateFlip(RotateFlipType.Rotate180FlipY);

            this.graphics.DrawImage(character, this.positionPlayer.X, this.positionPlayer.Y);
        }

        private void CheckUpdate(object sender, EventArgs e)
        {
            SetBackGround();
            if (currentAnimationIndex > 5) currentAnimationIndex = 1;
            
            currentAnimationIndex++;

            Animation();
        }

        private void StateFull(object sender, KeyEventArgs e)
        {
            currentAnimationIndex = 1;
            currentAnimation = CurrentAnimation.None;
        }

        private void Keyboard(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":
                    currentAnimation = CurrentAnimation.Up;
                    break;
                case "A":
                    currentAnimation = CurrentAnimation.Left;
                    break;
                case "S":
                    currentAnimation = CurrentAnimation.Down;
                    break;
                case "D":
                    currentAnimation = CurrentAnimation.Right;
                    break;
                case "Space":
                    currentAnimation = CurrentAnimation.Space;
                    break;
                case "R":
                    currentAnimation = CurrentAnimation.Attack;
                    break;
                default: 
                    currentAnimation = CurrentAnimation.None; 
                    break;
            }
            InfoKeyboard.Text = "Клваиша:\t" + e.KeyCode.ToString();  
        }

        private void Animation()
        {
            
            //character = Image.FromFile($@"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_5\Sprite\WalkRight\RightWalk{currentAnimationIndex}.png");

            switch (currentAnimation)
            {
                case CurrentAnimation.Right:
                    character = Image.FromFile($@"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_5\Sprite\Walk\RightWalk{currentAnimationIndex}.png");
                    this.graphics.DrawImage(character,positionPlayer.X,positionPlayer.Y);
                    if (!(this.positionPlayer.X >= Scene.Width - 120)) this.positionPlayer.X += 5;
                    SetAnimation();
                    LastPressed = CurrentAnimation.Right;
                    break;
                case CurrentAnimation.Left:
                    character = Image.FromFile($@"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_5\Sprite\Walk\RightWalk{currentAnimationIndex}.png");
                    character.RotateFlip(RotateFlipType.Rotate180FlipY);
                    this.graphics.DrawImage(character, positionPlayer.X, positionPlayer.Y);
                    if (!(this.positionPlayer.X < 15)) this.positionPlayer.X -= 5;
                    SetAnimation();
                    LastPressed = CurrentAnimation.Left;
                    break;
                case CurrentAnimation.None:
                    this.graphics.DrawImage(character, this.positionPlayer.X, this.positionPlayer.Y);
                    SetAnimation();
                    break;
                case CurrentAnimation.Space:
                    timer.Stop();
                    JumpCharacter();
                    JumpTimer.Start();
                    break;
                case CurrentAnimation.Attack:
                    timer.Stop();
                    JumpTimer.Stop();
                    AttackCharacter();
                    AttackTimer.Start();
                    break;

            }

            this.Scene.Image = bitmap;
        }

        private void SetBackGround()
        {
            this.graphics.DrawImage(Background, new Rectangle(0, 0, Scene.Width, Scene.Height));
            this.Scene.Image = bitmap;
        }

        private void SetAnimation()
        {
            currentJumpAnimationIndex = 1;
            currentAttackAnimationIndex = 1;
        }
    }


}