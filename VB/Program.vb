Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports System
Imports System.Windows.Forms

Namespace DisabledCells

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
