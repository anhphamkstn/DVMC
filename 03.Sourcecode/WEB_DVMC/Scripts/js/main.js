$(document).ready(function() {
	$('img.avatar').attr('src', 'https://graph.facebook.com/' + $('.menu-top-user').text() + '/picture');
	$('#loading').fadeOut(1000);
});
$('.loading').click(function() {
	$('#loading').show();
});
function noti(message, dismiss) {
	dismiss = dismiss || 1;
	if (dismiss == 1) message = "<a data-dismiss='toast'>Bỏ qua</a><div class='toast-text'>" + message + '</div>';
	//$('#noti').attr("data-original-title", message);
	$('#noti').click();
	$('.toast-inner').html(message);
}
function noti2(title, message) {
	title = title || "Thông báo";
	$('#notimodal .modal-inner').html(message);
	$('#notimodal .modal-title').html(title);
	$('#noti2').click();
}
function nl2br (str, is_xhtml) {   
    var breakTag = (is_xhtml || typeof is_xhtml === 'undefined') ? '<br />' : '<br>';    
    return (str + '').replace(/([^>\r\n]?)(\r\n|\n\r|\r|\n)/g, '$1'+ breakTag +'$2');
}