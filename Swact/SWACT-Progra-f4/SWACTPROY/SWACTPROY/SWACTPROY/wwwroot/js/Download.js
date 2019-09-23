html2canvas (document.body, {
    onrendered (canvas) {
        var link = document.getElementById('download');;
        var image = canvas.toDataURL();
        link.href = image;
        link.download = 'screenshot.png';

    }




});