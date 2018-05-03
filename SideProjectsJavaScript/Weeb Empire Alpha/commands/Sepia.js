var cloudinary = require('cloudinary').v2;
var uploads = {};
module.exports = {
  commands: [
    'sepia',
  ],
  usage: 'sepia <link>',
  description: 'sepia',
  category: 'Fun',
  execute: (client, message, args) => {
    cloudinary.config({
      cloud_name: fuck off cunt,
      api_key: fuck off cunt,
      api_secret: fuck off cunt,
    });
    cloudinary.uploader.upload(args[0], (err, image) => {
      if (err) { global.Logger.warn(err); }
      global.Logger.log(`* ${image.public_id}`);
      global.Logger.log(`* ${image.url}`);
      waitForAllUploads('random', err, image);
    });
    function waitForAllUploads(id, err, image) {
      uploads[id] = image;
      performTransformations();
    }
    function performTransformations() {
      cloudinary.url(uploads.random.public_id, { width: 200, height: 150, crop: 'fit', effect: 'sepia', format: 'jpg' });
      message.channel.send(new global.Discord.Attachment(
        cloudinary.url(uploads.random.public_id, { crop: 'fit', effect: 'sepia', format: 'jpg' })));
    }
  },

};
