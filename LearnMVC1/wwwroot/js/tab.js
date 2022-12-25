function openTab(evt, tabId) {
    var i, tabcontents, tablinks;
    // giau tabcontent
    tabcontents = document.querySelectorAll(".tabcontents");
    for (i = 0; i < tabcontents.length; i++) {
        tabcontents[i].style.display = "none";
    }

    //tắt các tablink trước đó đang active
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    //nhấn nút nào thì lấy nút đó = id và cho nó active
    document.getElementById(tabId).style.display = "block";
    evt.currentTarget.className += " active";
}
//lựa chọn mặc định 
document.getElementById("default").click();