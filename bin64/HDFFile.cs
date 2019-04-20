using System;

public class HDFFile
{
    private int _sdId;

    public HDFFile(string fullfilename)
    {

    }

    public static HDFFile New(string fullfilename)
    {
        HDFFile hdf = new HDFFile(fullfilename);

        hdf._sdId = HDF4.SDstart(fullfilename, HDF4.AccessCodes.DFACC_CREATE);

        return hdf;
    }

    public static HDFFile Open(string fullfilename)
    {
        HDFFile hdf = new HDFFile(fullfilename);

        hdf._sdId = HDF4.SDstart(fullfilename, HDF4.AccessCodes.DFACC_RDWR);

        if (hdf._sdId == -1)
            throw new Exception("Could not open " + fullfilename);

        hdf.Load();

        return hdf;
    }

    private void Load()
    {
        int num_ds = 0;
        int num_global = 0;
        HDF4.SDfileinfo(_sdId, out num_ds, out num_global);

        for (int i = 0; i < num_ds; i++)
        {
            //HDFDataSet hds = HDFDataSet.Load(_sdId, i);
            //if (!string.IsNullOrEmpty(hds.Name))
          //      _dataSets.Add(hds);
        }

        //_attributes = HDFAttribute.Load(_sdId, num_global);
    }

    // snip
}
