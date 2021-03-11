function toggleStyle(value) {
    var styles = document.getElementsByTagName('link');
    styles[0].href = value;
    console.log(value);
}