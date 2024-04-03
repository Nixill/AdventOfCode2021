string inputFile = await Kernel.GetInputAsync("Please select an input file.", "file");

string inputText = File.ReadAllText(inputFile);
string[] inputLines = File.ReadAllLines(inputFile);

return $"Currently loaded: {Path.GetFileName(inputFile)}";
