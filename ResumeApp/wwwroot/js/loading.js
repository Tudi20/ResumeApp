function updateProgress() {
    let progress = getComputedStyle(document.documentElement).getPropertyValue("--blazor-load-percentage");
    if (progress != null && progress != "") {
        progress = progress.replace("%", "")
        progress = Math.floor(parseFloat(progress));
        console.log("Loading progress of Web App: " + progress + "%");
        ui("#app-loading", progress);
    }
    if (progress >= 100) {
        console.info("Web App loaded!");
        return;
    }
    setTimeout(updateProgress, 100);
}