using OpenTK.Graphics;

namespace SorcerousLands
{
    partial class SorcerousLands
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            glControl1 = new OpenTK.GLControl.GLControl();
            начать = new кнопка_без_синего();
            продолжить = new кнопка_без_синего();
            настройки = new кнопка_без_синего();
            выход = new кнопка_без_синего();
            ввод_названия_игры = new TextBox();
            кнопка_начать_игру = new кнопка_без_синего();
            введите_имя_игры = new Label();
            SuspendLayout();
            // 
            // glControl1
            // 
            glControl1.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            glControl1.APIVersion = new Version(3, 3, 0, 0);
            glControl1.Dock = DockStyle.Fill;
            glControl1.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            glControl1.IsEventDriven = true;
            glControl1.Location = new Point(0, 0);
            glControl1.Name = "glControl1";
            glControl1.Profile = OpenTK.Windowing.Common.ContextProfile.Core;
            glControl1.SharedContext = null;
            glControl1.Size = new Size(784, 561);
            glControl1.TabIndex = 0;
            glControl1.Visible = false;
            // 
            // начать
            // 
            начать.Location = new Point(316, 115);
            начать.Name = "начать";
            начать.Size = new Size(143, 71);
            начать.TabIndex = 1;
            начать.Text = "Начать.";
            начать.UseVisualStyleBackColor = true;
            начать.Click += начать_Click;
            // 
            // продолжить
            // 
            продолжить.Location = new Point(316, 211);
            продолжить.Name = "продолжить";
            продолжить.Size = new Size(143, 71);
            продолжить.TabIndex = 2;
            продолжить.Text = "Продолжить";
            продолжить.UseVisualStyleBackColor = true;
            продолжить.Click += продолжить_Click;
            // 
            // настройки
            // 
            настройки.Location = new Point(316, 312);
            настройки.Name = "настройки";
            настройки.Size = new Size(143, 71);
            настройки.TabIndex = 3;
            настройки.Text = "Настройки.";
            настройки.UseVisualStyleBackColor = true;
            настройки.Click += настройки_Click;
            // 
            // выход
            // 
            выход.Location = new Point(316, 407);
            выход.Name = "выход";
            выход.Size = new Size(143, 71);
            выход.TabIndex = 4;
            выход.Text = "Выход.";
            выход.UseVisualStyleBackColor = true;
            выход.Click += выход_Click;
            // 
            // ввод_названия_игры
            // 
            ввод_названия_игры.Font = new Font("Segoe UI", 16F);
            ввод_названия_игры.Location = new Point(188, 288);
            ввод_названия_игры.Name = "ввод_названия_игры";
            ввод_названия_игры.Size = new Size(254, 36);
            ввод_названия_игры.TabIndex = 5;
            ввод_названия_игры.Visible = false;
            // 
            // кнопка_начать_игру
            // 
            кнопка_начать_игру.Font = new Font("Segoe UI", 16F);
            кнопка_начать_игру.Location = new Point(448, 288);
            кнопка_начать_игру.Name = "кнопка_начать_игру";
            кнопка_начать_игру.Size = new Size(94, 36);
            кнопка_начать_игру.TabIndex = 6;
            кнопка_начать_игру.Text = "Начать.";
            кнопка_начать_игру.UseVisualStyleBackColor = true;
            кнопка_начать_игру.Visible = false;
            кнопка_начать_игру.Click += кнопка_начать_игру_Click;
            // 
            // введите_имя_игры
            // 
            введите_имя_игры.AutoSize = true;
            введите_имя_игры.Font = new Font("Segoe UI", 16F);
            введите_имя_игры.Location = new Point(188, 252);
            введите_имя_игры.Name = "введите_имя_игры";
            введите_имя_игры.Size = new Size(202, 30);
            введите_имя_игры.TabIndex = 7;
            введите_имя_игры.Text = "Введите имя игры.";
            введите_имя_игры.Visible = false;
            // 
            // SorcerousLands
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(введите_имя_игры);
            Controls.Add(кнопка_начать_игру);
            Controls.Add(ввод_названия_игры);
            Controls.Add(выход);
            Controls.Add(настройки);
            Controls.Add(продолжить);
            Controls.Add(начать);
            Controls.Add(glControl1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(800, 600);
            Name = "SorcerousLands";
            Text = "Колдовские земли.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenTK.GLControl.GLControl glControl1;
        private кнопка_без_синего начать;
        private кнопка_без_синего продолжить;
        private кнопка_без_синего настройки;
        private кнопка_без_синего выход;
        private TextBox ввод_названия_игры;
        private кнопка_без_синего кнопка_начать_игру;
        private Label введите_имя_игры;
    }
}
