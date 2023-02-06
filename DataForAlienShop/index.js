const express = require("express");
const bodyParser = require("body-parser");
const mongoose = require("mongoose");
const userRoute = require("./routes/userRoute");

const app = express();

mongoose.connect("mongodb://localhost/mydb", {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});

// Check if the connection was successful
const db = mongoose.connection;
db.on("error", console.error.bind(console, "MongoDB connection error:"));
db.once("open", function () {
  console.log("MongoDB connected successfully!");
});

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

app.use("/users", userRoute);

app.listen(27017, () => {
  console.log("Server is running on port 27017");
});

