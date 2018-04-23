using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using DevExpress.Skins;
using DevExpress.XtraEditors.Drawing;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            int x = 30;
            int y = 30;
            SkinCheckObjectPainter p = new SkinCheckObjectPainter(UserLookAndFeel.Default);
            CheckObjectInfoArgs args = new CheckObjectInfoArgs(DevExpress.Utils.AppearanceObject.ControlAppearance);
            args.Graphics = e.Graphics;
            DrawCheckBox(x, y, "Caramel", CheckState.Unchecked, CheckStyles.Standard, p, args);
            x += 30;
            DrawCheckBox(x, y, "Caramel", CheckState.Checked, CheckStyles.Standard, p, args);
            x += 30;
            DrawCheckBox(x, y, "Blue", CheckState.Checked, CheckStyles.Radio, p, args);
            x += 30;
            DrawCheckBox(x, y, "Blue", CheckState.Unchecked, CheckStyles.Radio, p, args);
        }
        private void DrawCheckBox(int x, int y, string skinName, CheckState state, CheckStyles style,
            SkinCheckObjectPainter painter, CheckObjectInfoArgs args) {
            ((UserLookAndFeel)painter.Provider).SkinName = skinName;
            args.Bounds = new Rectangle(x, y, 0, 0);
            painter.CalcObjectBounds(args);
            args.CheckState = state;
            args.CheckStyle = style;
            painter.DrawObject(args);
        }
    }
}
