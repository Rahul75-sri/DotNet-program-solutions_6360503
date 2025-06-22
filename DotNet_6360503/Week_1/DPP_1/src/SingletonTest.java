public class SingletonTest {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        System.out.println("Same instance? " + (logger1 == logger2));

        logger1.log("First log entry");
        logger2.log("Second log entry");

        Runnable task = () -> {
            Logger threadLogger = Logger.getInstance();
            threadLogger.log("Log from " + Thread.currentThread().getName());
        };

        new Thread(task, "Thread-1").start();
        new Thread(task, "Thread-2").start();
    }
}
