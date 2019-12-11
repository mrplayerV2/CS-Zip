using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;

public class ZipTool
{
	public void unzip(string zipfile, string outputPath)
	{
		FastZip oZip = new FastZip();
		if (File.Exists(zipfile))
		{
			try
			{
				oZip.ExtractZip(zipfile, outputPath, "");
			}
			catch (Exception)
			{
			}
		}
	}

	public bool zip(string sourcePath, string zipFilename)
	{
		FastZip oZip = new FastZip();
		try
		{
			oZip.CreateZip(zipFilename, sourcePath, recurse: true, "");
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
