package factories;

import documents.Documents;
import documents.PdfDocument;

public class PdfDocumentFactory extends DocumentFactory {
    @Override
    public Documents createDocument() {
        return new PdfDocument();
    }
}