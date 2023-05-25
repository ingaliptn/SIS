import psutil, os.path, os, time, sys
import win32file 
import win32event
import win32con
import threading
import platform, getpass
from psutil._common import bytes2human


def pprint_ntuple(nt):
    for name in nt._fields:
        value = getattr(nt, name)
        if name != 'percent':
            value = bytes2human(value)
        print('%-10s : %7s' % (name.capitalize(), value))


disks = psutil.disk_partitions()
print(f'У системі існують {len(disks)} диски.')

f = open('log.txt', 'r+', encoding='UTF-8')
for i in range(len(disks)):
    disk = str(disks[i]).split('\'')[1]
    fsys = str(disks[i]).split('\'')[5]
    memory = psutil.disk_usage(disk)
    print(f'Диск: {disk}, файлова система: {fsys}, використаний простір {bytes2human(memory.used)} Gb, '
          f'вільний простір {bytes2human(memory.free)} Gb.')

systemDrive = os.environ.get('SYSTEMDRIVE')
print(f'Диск {systemDrive}, є системним диском')
print(f'Назва комп\'ютера: {platform.node()}')
print(f'Назва поточного користувача: {getpass.getuser()}')
print(f'Поточний каталог: {os.getcwd()}')
sysCat = os.environ.get('SYSTEMROOT')
tempCat = os.environ.get('TEMP')
print(f'Поточний системний каталог: {sysCat}')
print(f'Тимчасовий каталог: {tempCat}')
print(f'Інформація про системну пам\'ять')
pprint_ntuple(psutil.virtual_memory())

ACTION = []


def ACTIONSS(done, interval=1):
    ACTIONS = {
        1: "Created",
        2: "Deleted",
        3: "Updated",
        4: "Renamed from something",
        5: "Renamed to something"
    }
    FILE_LIST_DIRECTORY = 0x0001

    path_to_watch = r"C:\Users\ingaliptn\Desktop\test folder"  # Шлях до дерикторії для спостереження
    hDir = win32file.CreateFile(
        path_to_watch,
        FILE_LIST_DIRECTORY,
        win32con.FILE_SHARE_READ | win32con.FILE_SHARE_WRITE | win32con.FILE_SHARE_DELETE,
        None,
        win32con.OPEN_EXISTING,
        win32con.FILE_FLAG_BACKUP_SEMANTICS,
        None
    )
    while not done.wait(interval):
        results = win32file.ReadDirectoryChangesW(
            hDir,
            1024,
            True,
            win32con.FILE_NOTIFY_CHANGE_FILE_NAME |
            win32con.FILE_NOTIFY_CHANGE_DIR_NAME |
            win32con.FILE_NOTIFY_CHANGE_ATTRIBUTES |
            win32con.FILE_NOTIFY_CHANGE_SIZE |
            win32con.FILE_NOTIFY_CHANGE_LAST_WRITE |
            win32con.FILE_NOTIFY_CHANGE_SECURITY,
            None,
            None
        )
        for action, file in results:
            full_filename = os.path.join(path_to_watch, file)
            act = str(f'{full_filename} {ACTIONS.get(action, "Unknown")}\n')
            ACTION.append(str(f'{full_filename} {ACTIONS.get(action, "Unknown")}\n'))
            print(act)


done = threading.Event()
threading.Thread(target=ACTIONSS, args=[done], daemon=True).start()
input('Press Enter to exit.\n')
done.set()
for i in range(len(ACTION)):
    f.write(ACTION[i])
f.close()
