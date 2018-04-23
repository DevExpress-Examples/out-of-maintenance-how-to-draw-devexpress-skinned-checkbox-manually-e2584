Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim x As Integer = 30
			Dim y As Integer = 30
			Dim p As New SkinCheckObjectPainter(UserLookAndFeel.Default)
			Dim args As New CheckObjectInfoArgs(DevExpress.Utils.AppearanceObject.ControlAppearance)
			args.Graphics = e.Graphics
			DrawCheckBox(x, y, "Caramel", CheckState.Unchecked, CheckStyles.Standard, p, args)
			x += 30
			DrawCheckBox(x, y, "Caramel", CheckState.Checked, CheckStyles.Standard, p, args)
			x += 30
			DrawCheckBox(x, y, "Blue", CheckState.Checked, CheckStyles.Radio, p, args)
			x += 30
			DrawCheckBox(x, y, "Blue", CheckState.Unchecked, CheckStyles.Radio, p, args)
		End Sub
		Private Sub DrawCheckBox(ByVal x As Integer, ByVal y As Integer, ByVal skinName As String, ByVal state As CheckState, ByVal style As CheckStyles, ByVal painter As SkinCheckObjectPainter, ByVal args As CheckObjectInfoArgs)
			CType(painter.Provider, UserLookAndFeel).SkinName = skinName
			args.Bounds = New Rectangle(x, y, 0, 0)
			painter.CalcObjectBounds(args)
			args.CheckState = state
			args.CheckStyle = style
			painter.DrawObject(args)
		End Sub
	End Class
End Namespace
