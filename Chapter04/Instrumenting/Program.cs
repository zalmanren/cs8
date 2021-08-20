using System.Diagnostics;
using System.IO;

// write to a text file in the project folder
Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

// text writer is buffered, so this option calls
// Flush() on all listeners after writing
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I'm watching!");
Trace.WriteLine("Trace says, I'm watching!");
