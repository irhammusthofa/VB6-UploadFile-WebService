# Upload File via Web Service from Visual Basic 6.0
Upload file via web service atau http/https dari visual basic 6.0. Webservice bisa dibuat menggunakan php,asp atau yang lainnya. 

<h1>Berikut ini cara menggunakannya :</h1>
<code>
call UpLoadData("C:/namafile.txt","https://domain.com/upload.php","nama_file.txt")  
</code>
ada tiga parameter pada fungsi <code>UpLoadData</code> yaitu :
1. <code>strFilename</code> alamat file yang akan diupload
2. <code>strTargetUrl</code> URL Webservice
3. <code>namaFile</code> (Opsional) Nama File jika ingin diubah



