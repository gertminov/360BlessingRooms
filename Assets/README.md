﻿# Segensräume VR

## Funktion

Die Videos auf der VideoSphere abgespielt, 2 sekunden bevor das video zu ende ist, wird ein Übergang zu schwarz getriggered (ControlCanvas/FadeToBlack)
Sobald das bild ganz schwarz ist, wird das neue Video geladen und wieder eingeblendet. Die Logik ist in /Scripts/playController.cs die animation in /Scripts/FadeToBlack.cs

## Videos hinzufügen

- Die videos am besten in /Resources/Video importieren (rechtsklick -> import new assert)
- Das neues Video im ControlCanvas Objekt beim "Play controller Script" in die Video liste ziehen
- Fertig