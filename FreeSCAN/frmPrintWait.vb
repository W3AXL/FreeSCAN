Option Strict Off
Option Explicit On
Friend Class frmPrintWait
	Inherits System.Windows.Forms.Form

	Private Sub cmdAbort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAbort.Click
		blnAbortOp = True
	End Sub

	Private Sub frmPrintWait_load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
	End Sub
End Class