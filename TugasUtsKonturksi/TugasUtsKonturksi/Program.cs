class Program
{
    static void Main()
    {
        var tasks = TaskPersistence.LoadTasks();
        string input;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Tambah Tugas");
            Console.WriteLine("2. Lihat Tugas");
            Console.WriteLine("3. Tandai Selesai");
            Console.WriteLine("4. Hapus Tugas");
            Console.WriteLine("5. Simpan & Keluar");
            Console.Write("Pilih menu (1-5): ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddTaskModule.TambahTugas(tasks);
                    break;
                case "2":
                    TaskListingModule.TampilkanDaftar(tasks);
                    break;
                case "3":
                    TaskListingModule.TandaiSelesai(tasks);
                    break;
                case "4":
                    TaskListingModule.HapusTugas(tasks);
                    break;
                case "5":
                    TaskPersistence.SimpanTasks(tasks);
                    Console.WriteLine("Tugas disimpan. Keluar...");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        } while (input != "5");
    }
}
