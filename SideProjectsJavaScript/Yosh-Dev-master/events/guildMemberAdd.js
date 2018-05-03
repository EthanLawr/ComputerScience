module.exports = client => {

  client.on("guildMemberAdd",  (member) => {
    try {
      let memberguild = member.guild;
      let userid= member.user.id;
      if(memberguild.id=="384846849296695298"){
        client.channels.get("384846849296695300")
		  .send(`Welcome to ${message.guild.name}, <@!${userid}>`);
      } else {
		  return;
      }
    } catch (err) {
      Logger.warn(err);
    }
  });
  
}; 