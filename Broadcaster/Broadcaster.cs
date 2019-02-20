using System;
using Oxide.Core;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("Broadcaster", "zyankali", "0.0.1")]
    [Description("Allows players to set up thair own ingame Radiostation and listen to - placeholder")]
    class Broadcaster : CovalencePlugin
    {
        private void Init()
        {
            Puts("Broadcaster Plugin had been Loaded! \n Beware, plugin is still in heavy developement!");
        }

        object OnPlayerVoice(BasePlayer player, Byte[] data)
        {
            Puts("OnPlayerVoice works!");
            return null;
        }

        // Usable commands Listed here.

        //Welcome and warrity.
        [Command("brc")]
        private void brcCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Welcome to the Broadcaster Plugin\n--------------\n By using this Plugin you agree to the ToS of the Server Owner.\n You also avoid copyright infringements of any kind!\n With the command \"brc.help\" you can get some more informations how to use the Plugin.\n --------------\n" +
                " Plugin created by Zyankali (C)2019");
        }
        
        // brc Help info text
        [Command("brc.help")]
        private void brchelpCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("---------- HELP ----------" +
                "\n brc.stations - Lists all avaidable stations with frequenzy or channel strukture" +
                "\n brc.register - Register your Station to a frequenz or channel with stationname." +
                "\n brc.unregister - Unregister your Station and free the used frequenz, channel and stationname." +
                "\n brc.available - shows the free frequenzis or channels you can rigister to your Station." +
                "\n brc.start - Start your Broadcast in the broadcasting network!" +
                "\n brc.stop - Stops your Broadcasting!" +
                "\n brc.listen - Listen to a specific station with using the name,channel or frequenzy." +
                "\n brc.turnoff - Stops your Listening to any Station!" +
                "\n ---------- ADMIN ----------" +
                "\n brc.networkon - Starts your Ingame Broadcasting Network System!" +
                "\n brc.networkoff - Stops and Disables your Broadcasting Network System and also Stops ANY running Station!" +
                "\n brc.status - Shows the Status of the Rigistered Stations if they are Broadcasting or Not. Usefull to see what Station is used or not to free Space." +
                "\n ---------- END of HELP ---------- \n");
        }

        // brc get List of avaidable Broadcasters and thair channels or frequenszies
        [Command("brc.stations")]
        private void brcstationsCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Get a list of avaidable Broadcasters!" + 
                "\n Broadcaster + chanel or frequenzy");
        }

        // brc register your Station to the Broadcaster Network System
        [Command("brc.register")]
        private void brcregisterCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Register your Station to the Broadcaster Network");
        }

        // brc unregister your Station from the Broadcaster Network System
        [Command("brc.unregister")]
        private void brcunregisterCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Unregister your Station from the Broadcaster Network");
        }

        // brc display the available radio station places in numbers
        [Command("brc.available")]
        private void brcavailableCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Displays the available for registering your radio station chanels or frequenzis in numbers.");
        }

        // brc start your Broadcast
        [Command("brc.start")]
        private void brcstartCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Starts your Broadcast!");
        }

        // brc Stops your Broadcast
        [Command("brc.stop")]
        private void brcstopCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Stops your Broadcast!");
        }

        // brc listen to a specific Radio Station
        [Command("brc.listen")]
        private void brclistenCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Listen to a specific Station via frequenzy or channel.");
        }

        // brc Stop listen to any radio station
        [Command("brc.turnoff")]
        private void brcturnoffCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("It stops your listening to any Station.");
        }

        // brc ADMIN Start your Broadcaster Network - Usefull after the Broadcasting Network had been stopped for reasons.
        [Command("brc.networkon")]
        private void brcnetworkonCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("It starts your Broadcaster Network System.");
        }

        // brc ADMIN Stops and Shuts down your Broadcaster network and also stops ANY Broadcasts - USefull if Server get´s to laggy or other stuff had to be done.
        [Command("brc.networkoff")]
        private void brcnetworkoffCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("It stops your Broadcaster Network System and also any Broadcasting Stations");
        }

        // brc ADMIN displays the Status of Stations if thay are Broadcasting or not - usefull when ADMIN wants to free Frequenzies or channels.
        [Command("brc.status")]
        private void brcstatusCommand(IPlayer player, string command, string[] args)
        {
            player.Reply("Shows the ON or OFF status of registered Stations.");
        }
    }

}
