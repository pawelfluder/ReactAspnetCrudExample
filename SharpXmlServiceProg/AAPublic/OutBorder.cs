using SharpObjToXmlServiceProg.Service;

namespace SharpObjToXmlServiceProg.AAPublic
{
    public static class OutBorder
    {
        public static IObjToXmlService ObjToXmlService()
        {
            var result = new ObjToXmlService();
            return result;
        }
    }
}
