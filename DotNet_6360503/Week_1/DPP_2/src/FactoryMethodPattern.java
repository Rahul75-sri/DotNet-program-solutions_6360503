// src/Main.java

import documents.Documents;
import factories.DocumentFactory;
import factories.ExcelDocumentFactory;
import factories.PdfDocumentFactory;
import factories.WordDocumentFactory;

public class FactoryMethodPattern {
    public static void main(String[] args) {
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();

        Documents wordDoc = wordFactory.createDocument();
        Documents pdfDoc = pdfFactory.createDocument();
        Documents excelDoc = excelFactory.createDocument();

        wordDoc.open();
        pdfDoc.save();
        excelDoc.open();
    }
}
