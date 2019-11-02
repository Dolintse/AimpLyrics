using System.Runtime.InteropServices;

namespace Aimp4.Api
{
    [Guid("41494D50-4578-7446-696C-654578706472")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IAIMPExtensionFileExpander
    {
        void Expand(IAIMPString fileName, out IAIMPObjectList list, IAIMPProgressCallback progressCallback);
    }
}