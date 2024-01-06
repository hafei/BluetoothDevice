namespace BluetoothDevice;

class Program
{
    static void Main(string[] args)
    {
        BluetoothLEAdvertisementWatcher watcher = new BluetoothLEAdvertisementWatcher();
        watcher.Received += OnAdvertisementReceived;
        watcher.Start();
    }
}