Public Class Form1
    Private Sub btnSchwuchtel_Click(sender As Object, e As EventArgs) Handles btnSchwuchtel.Click
        Dim dr As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "SCHWUCHTEL-EID", MessageBoxButtons.YesNo)
        If dr = DialogResult.Yes Then
            MessageBox.Show("jHerr K.Lopapier, Haha sie sind wirklich eine Schwuchtel!a")
            MessageBox.Show("Eine sehr große sogar sie Klopapier!!")
        Else
            MessageBox.Show("jDu bist trotzdem eine Karsten Lopapier!!!a")
            MessageBox.Show("Eine sehr große sogar Karsten!!")
        End If

        Dim df As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "Ja oder Nein?", MessageBoxButtons.YesNo)
        If df = DialogResult.Yes Then
            MessageBox.Show("Richtige Antwort! Hier sind überall nur Schwuchteln verdammt noch mal ... Nada ")
        Else
            MessageBox.Show("Falsche Antwort, Hast du das JA übersehen? Es bezog sich auf die nächste Frage. Versuch es nochmal! Na endlich mal einer der hier keine Schwuchtel ist, danke K.Lopapier !!! NEIN")
        End If
        Dim da As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "Ja oder Nein?", MessageBoxButtons.YesNo)
        If da = DialogResult.Yes Then
            MessageBox.Show("Falsche Antwort, hast du das NEIN eben übersehen? Man man man bist du schlecht in diesem Spiel! Ich gebe bald meinen Geist auf hier als Schwuchtel-Wärter, hier sind nur Lügner und Heuchler NEIN")
        Else
            MessageBox.Show("Richtige Antwort! Aber Du lügst K.Lopapier! Sag die Wahrheit oder stirb. Also ? NEIN ")
        End If
        Dim db As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "Ja oder Nein?", MessageBoxButtons.YesNo)
        If db = DialogResult.Yes Then
            MessageBox.Show("Bist du der Ja-Sager ? Hör auf damit! das war erneut die falsche Antwort JA JA JA JA JAAA")
        Else
            MessageBox.Show("Richtig geantwortet. Moment... Was? Nein? Du bist hier nur am lügen, Egal was du sagst, du nicht sprechen die Wahrheit K.Lopapier JAJAJAJAJAJA")
        End If
        Dim dc As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "Welche Antwort?", MessageBoxButtons.YesNo)
        If dc = DialogResult.Yes Then
            MessageBox.Show("Richtige Antwort Jawoll!!! Mr. Herr Professor Dr. med. K.Lopapier.... das hier ist der Eingang zu einem Waschhaus, sie sind falsch ACHTUNG HINT ---DRÜCKE NEIN--- HINT")
        Else
            MessageBox.Show("Sie sollten vielleicht noch mal die Spielregeln durch lesen Mr. Herr Professor Dr. med. K.Lopapier.... das hier ist der Eingang zu einem Toilettenhaus im Freien, sie sind falsch ACHTUNG HINT ---DRÜCKE NEIN--- HINT")
        End If
        Dim de As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "Ja oder Nein?", MessageBoxButtons.YesNo)
        If de = DialogResult.Yes Then
            MessageBox.Show("Du wagst es erneut JA zu drücken ohne meine Erlaubnis??? Sorry, es ist mein Auftrag öfters zu fragen, um sicher zu gehen, Also ja, sie sind eine Schwuchtel entgültig ALLES FALSCH FUCK du hast 1 Freeticket für das Spiel gewonnen durch falsche Antworten, You're Welcome Amigo")
            MessageBox.Show("Hier sind überall nur Schwuchteln verdammt noch mal ...")
        Else
            MessageBox.Show("Du hast tatsächlich auf NEIN gedrück... Sorry, es ist mein Auftrag öfters zu fragen, um sicher zu gehen, Also nein, sie sind entgültig keine Schwuchtel ALLES FALSCH FUCK du bekommst 1 Freeticket für das Spiel weil du falsche Antworten gegeben hast... oder nicht? You're Welcome Amigo")
            MessageBox.Show("Na endlich mal einer der hier keine Schwuchtel ist, danke K.Lopapier !!!")
        End If
        Dim dd As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "Ja oder Nein?", MessageBoxButtons.YesNo)
        If dd = DialogResult.Yes Then
            MessageBox.Show("Das Ende ist fast erreicht. Ein hin und her! So Mir reichts. Ich kündige! Suchen sie sich einen anderen Türsteher des Örtlichen Klo-Verbandes")
            MessageBox.Show("Das ist der totale Unsinn hier!!! Wer hat sich dieses kack Spiel ausgedacht")
            MessageBox.Show("Jonas Zadach aus Laatzen Germany")
            MessageBox.Show("Den knöpfe ich mir vor")
            MessageBox.Show("Man wird hier nur verarscht! Was für eine Verarschung schon wieder")
            MessageBox.Show("Seit 7 Jahren mache ich das hier mit Türstehen für Toilettenbenutzer im Öfftentlichen und alles was ich hier sehe Sind Transsexuelle Schwuchteln! Igitt")
            MessageBox.Show("Vielen Dank, dass sie das neue Action-Spiel Türsteher vom FESTIVAL DEVELOPMENT gespielt haben, bis bald. Copyright D2016 Jonas Zadach Festival Development")
        Else
            MessageBox.Show("Ist ein mal 16 wirklich 108? Ich würde sagen NEIN! Immer diese Ungenauen Antworten! So mir reichts !!! Ich kündige !!! Suchen sie sich einen neuen Türsteher!")
            MessageBox.Show("Das ist der totale Unsinn hier!!! Wer hat sich dieses kack Spiel ausgedacht")
            MessageBox.Show("Jonas Zadach aus Laatzen Germany nahe Hannover....")
            MessageBox.Show("Den knöpfe ich mir vor")
            MessageBox.Show("Ich mache das hier jetzt schon seit sieben Jahren! Jeden Tag werden neue Schwule zum Himmeltor kommen")
            MessageBox.Show("Vielen Dank, dass sie das neue Action-Spiel Türsteher vom FESTIVAL DEVELOPMENT gespielt haben, bis bald. Copyright D2016 Jonas Zadach Festival Development")
        End If
        Dim dz As DialogResult = MessageBox.Show(DirectCast(sender, Button).Text, "", MessageBoxButtons.YesNo)
        If dz = DialogResult.Yes Then
            MessageBox.Show("FALSCH")
            MessageBox.Show("VERLOREN, NOCHMAL VERSUCHEN... und ne Schwuchtel biste trotzdem du homo, hmmmmmmmmm bis zum nächsten Versuch")
        Else
            MessageBox.Show("richtig.... aber VERSUCHS NOCH MAL, DAS WAR KEIN FEHLERFREIER WEG")
            MessageBox.Show("Dicke Schwuchtel biste trotzdem du Homo! Bis zum nächsten mal!")
        End If
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.BackColor = Color.LightGreen
    End Sub
End Class
