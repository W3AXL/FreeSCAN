Option Strict Off
Option Explicit On
Friend Class frmViewInvalids
	Inherits System.Windows.Forms.Form

	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Visible = False
	End Sub

	Private Sub frmViewInvalids_load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
	End Sub

End Class