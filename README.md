# PoC.ChildProcessFolderBrowser
Launches a child process that then shows a file browser, and then returns the users selection in the standard output.

## What does it do

1) Host console app launches
2) It spawns a child process and wires up to the standard out
3) Child process launches an `OpenFileDialog`, prints file path to standard out
4) Host process reads standard out and prints file path to screen
