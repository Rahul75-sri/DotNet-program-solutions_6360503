package factories;

import documents.Documents;
import documents.ExcelDocument;

public class ExcelDocumentFactory extends DocumentFactory {
    @Override
    public Documents createDocument() {
        return new ExcelDocument();
    }
}