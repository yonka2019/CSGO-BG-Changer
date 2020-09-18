namespace CSGO_BG_Changer
{
    public static class Settings
    {
        public const string VlcLib = @".\libvlc\", //VLC library
        Version = "1.0", //Version of the program
        LastUpdate = "18.09.2020", //Date of the last update of the program
        BackgroundFolder = @".\Backgrounds\"; //Folder of PROGRAM backgrounds
        public static string CsgoBGFolder = null;
        public static string[] strings = new string[35];
        public static void SetRU()
        {
            strings[0] = "Применить Выбранный Фон";
            strings[1] = "Выберите фон со списка снизу";
            strings[2] = "Язык";
            strings[3] = "Сбросить Фон";
            strings[4] = "Инфо";
            strings[5] = "Введите путь к Counter Strike: Global Offensive";
            strings[6] = "Введите путь к CS:GO";
            strings[7] = "Counter Strike: Global Offensive не найден. Введите верный путь";
            strings[8] = "Неверный путь";
            strings[9] = "Путь к CS:GO был успешно найден! \n";
            strings[10] = "\n\nЭто верный путь к игре?";
            strings[11] = "Путь найден!";
            strings[12] = "Путь к CS:GO";
            strings[13] = "Текущий путь:";
            strings[14] = "Изменить Путь";
            strings[15] = $"Создатель: Yonka\n\nDiscord: Yonka#9992\n\nVK: vk.com/yonka2019\n\nВерсия программы: {Version}\nПоследнее обновление: {LastUpdate}\n\n• Чтобы добавить фон, нажмите на кнопку [+] (Принимается только фон с расширением .webm)!\n\n• Чтобы удалить фон со списка, нажмите на кнопку [-] (удалится фон - на который выбран)\n\n• Если остались вопросы вы можете смело спросить их у меня =)";
            strings[16] = "Фон успешно добавлен!";
            strings[17] = "Успешно";
            strings[18] = "Успешно удален!";
            strings[19] = "Фон успешно установлен!";
            strings[20] = "Ошибка";
            strings[21] = "Данный файл уже существует";
            strings[22] = "Фон успешно сброшен!";
            strings[23] = "Вы уверены?";
            strings[24] = "Сброс Фона";
            strings[25] = "Удаление Фона";
            strings[26] = "Неверное расширение файла. Фон должен иметь расширение .webm";
            strings[27] = "Открыть папку с фонами приложения";
            strings[28] = "Обновить список фонов";
            strings[29] = "Добавить новый фон";
            strings[30] = "Удалить выбранный фон";
            strings[31] = "Чтобы изменить фон на новый, нужно выбрать фон \"База Феникса\" в списке фонов (в игре)";
            strings[32] = "Фон CS:GO";
        }
        public static void SetEN()
        {
            strings[0] = "Apply Selected Background";
            strings[1] = "Select background from the list below";
            strings[2] = "Language";
            strings[3] = "Reset Background";
            strings[4] = "Info";
            strings[5] = "Enter path to Counter Strike: Global Offensive";
            strings[6] = "Enter CS:GO Path";
            strings[7] = "Counter Strike: Global Offensive was not found. Please enter a valid path";
            strings[8] = "Invalid path";
            strings[9] = "Successfully found a CS:GO Path! \n";
            strings[10] = "\n\nIs this the correct path?";
            strings[11] = "Path Found!";
            strings[12] = "CS:GO Path";
            strings[13] = "Current path:";
            strings[14] = "Change Path";
            strings[15] = $"Created by: Yonka\n\nDiscord: Yonka#9992\n\nProgram version: {Version}\nLast update: {LastUpdate}\n\n• To add new background, press the button [+] (you can add only backgrounds with .webm file extensions)!\n\n• To remove background, press the button [-] (Selected background will be removed)\n\n• If you have any question you can ask me =)";
            strings[16] = "Background Successfully added!";
            strings[17] = "Success";
            strings[18] = "Successfully removed!";
            strings[19] = "Background successfully installed!";
            strings[20] = "Error";
            strings[21] = "This file already exist";
            strings[22] = "Background successfully reseted!";
            strings[23] = "Are you sure?";
            strings[24] = "Background Resetting";
            strings[25] = "Background Removing";
            strings[26] = "Incorrect file extension. The background should be with .webm extension";
            strings[27] = "Open folder with application backgrounds";
            strings[28] = "Reload background list";
            strings[29] = "Add new background";
            strings[30] = "Remove selected background";
            strings[31] = "To change the background to new, you should select the \"Pheonix Facility\" background in backgrounds list (in csgo)";
            strings[32] = "CS:GO Background";
        }
    }
}
