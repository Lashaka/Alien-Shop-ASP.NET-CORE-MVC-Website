const User = require("../models/user");

exports.createUser = (req, res) => {
  const newUser = new User({
    name: req.body.name,
    email: req.body.email,
  });

  newUser.save((error, user) => {
    if (error) {
      res.send(error);
    } else {
      res.send(user);
    }
  });
};
