const Logger = require('../functions/logger');
const config = require('../config');
module.exports = (bot) => {
  Logger.start(`User: ${bot.user.tag}\n\t\t\t\tGuilds: ${bot.guilds.size}\n\t\t\t\tChannels: ${bot.channels.size}\n\t\t\t\tPrefix: ${config.discord.prefix}\n\t\t\t\tDefault Color: ${config.discord.defaultColor}`);
};
