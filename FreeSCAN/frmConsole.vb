Option Strict Off
Option Explicit On
Friend Class frmConsole
	Inherits System.Windows.Forms.Form

	Private Sub frmConsole_load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
	End Sub

End Class