using BL;
using DL;
using UI;

string connectionString = File.ReadAllText("./connectString.txt");
IRepository repo = new DBRepo(connectionString);
IPSBL bl = new PSBL(repo);
new PlantShop(bl).Start();