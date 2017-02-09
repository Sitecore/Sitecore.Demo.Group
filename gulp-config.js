module.exports = function() {
  var instanceRoot = "C:\\Code\\Sitecore\\Sites\\Habitat.dev.local";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "Sitecore.Demo.Group",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}