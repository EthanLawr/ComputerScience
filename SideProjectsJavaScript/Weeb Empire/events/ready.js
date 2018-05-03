module.exports = client => {
  global.Logger.start(`User: ${client.user.tag} (${client.user.id})\n\t\t\t\tGuilds: ${client.guilds.size}\n\t\t\t\t` +
    `Channels: ${client.channels.size}\n\t\t\t\tPrefix: ${global.config.discord.prefix}\n\t\t\t\tDefault Color: ` +
	`${global.config.discord.defaultColor}`);
  client.user.setActivity(`!-help | Serving ${client.users.size} weebs`, 'https://twitch.tv/twitch');
  /*  Client.user.setStatus('online');
client.user.setPresence({
  status: 'online',
  activity: {
    name: process.env.BETA=='true'?'Chips PTB':'-help | "-chess help" is here!! | 100k members!!!',
    type: 'STREAMING',
    url: 'https://twitch.tv/twitch',
  }
});
*/
};
