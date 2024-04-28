mergeInto(LibraryManager.library, {

  Debug: function () {
    console.log("реклама");
  },

  ShowAds: function () {
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          console.log("реклама");
          // some action after close
        },
        onError: function(error) {
          // some action on error
        }
      }
      })    
  },

});